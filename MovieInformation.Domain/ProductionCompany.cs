using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformation.Domain
{
    public class ProductionCompany: Entity
    {
        public ProductionCompany()
        {
        }

        public Company Company { get; set; }
        public Guid CompanyId { get; set; }

        public Movie Movie { get; set; }
        public Guid MovieId { get; set; }
    }
}
