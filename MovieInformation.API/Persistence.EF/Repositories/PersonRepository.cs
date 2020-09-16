using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieInformation.API.Persistence.EF.Contracts;
using MovieInformation.Domain;
using MovieInformation.Persistence.EF;

namespace MovieInformation.API.Persistence.EF.Repositories
{
    public class PersonRepository : EfRepository<Person>
    {
        public PersonRepository(MovieInformationDbContext dbContext) : base(dbContext) { }
    }
}
