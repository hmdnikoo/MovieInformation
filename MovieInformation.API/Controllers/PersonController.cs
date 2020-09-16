using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieInformation.API.Models;
using MovieInformation.API.Persistence.EF.Contracts;
using MovieInformation.Domain;


namespace PersonInformation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IRepository<Person> _personRepository;
        public PersonController(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PersonInfo personItem)
        {
            var person = new Person(personItem.FirstName, personItem.LastName, personItem.Details);
            await _personRepository.AddAsync(person);

            return Created(String.Empty, person.Id);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update([FromBody] PersonInfo personItem)
        {
            var person = await _personRepository.GetByIdAsync(personItem.Id);
            person.Update(personItem.FirstName, personItem.LastName, personItem.Details);
            _personRepository.Update(person);

            return Ok();
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetPerson(Guid id)
        {
            var person = await _personRepository.GetByIdAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeletePerson(Guid id)
        {
            var person = await _personRepository.GetByIdAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            _personRepository.Delete(person);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetPersons()
        {
            var persons = await _personRepository.GetAll();
            if (persons.Count == 0)
            {
                return NotFound();
            }

            return Ok(persons);
        }
    }
}
