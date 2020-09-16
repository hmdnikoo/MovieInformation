using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieInformation.API.Models
{
    public class CompanyInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundedDate { get; set; }
        public string HeadquartersLocation { get; set; }
        public string Details { get; set; }
    }
}
