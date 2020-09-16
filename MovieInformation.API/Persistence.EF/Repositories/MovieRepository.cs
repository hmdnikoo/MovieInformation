

using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieInformation.API.Persistence.EF.Contracts;
using MovieInformation.API.Persistence.EF.Repositories;
using MovieInformation.Domain;

namespace MovieInformation.Persistence.EF
{
    public class MovieRepository : EfRepository<Movie>
    {
        public MovieRepository(MovieInformationDbContext dbContext) : base(dbContext) { }
    }
}
