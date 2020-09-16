using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieInformation.API.Models;
using MovieInformation.API.Persistence.EF.Contracts;
using MovieInformation.Domain;

namespace MovieInformation.API.Controllers
{
    public class CompanyController : ControllerBase
    {
        private readonly IRepository<Company> _companyRepository;

        public CompanyController(IRepository<Company> companyRepository)
        {
            _companyRepository = companyRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CompanyInfo companyItem)
        {
            var company = new Company(
                companyItem.Name,
                companyItem.FoundedDate,
                companyItem.HeadquartersLocation,
                companyItem.Details);
            await _companyRepository.AddAsync(company);

            return Created(String.Empty, company.Id);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update([FromBody] CompanyInfo companyItem)
        {
            var company = await _companyRepository.GetByIdAsync(companyItem.Id);
            company.Update(
                companyItem.Name,
                companyItem.FoundedDate,
                companyItem.HeadquartersLocation,
                companyItem.Details
            );
            _companyRepository.Update(company);

            return Ok();
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetCompany(Guid id)
        {
            var company = await _companyRepository.GetByIdAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            return Ok(company);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteCompany(Guid id)
        {
            var company = await _companyRepository.GetByIdAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            _companyRepository.Delete(company);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _companyRepository.GetAll();
            if (companies.Count == 0)
            {
                return NotFound();
            }

            return Ok(companies);
        }
    }
}
