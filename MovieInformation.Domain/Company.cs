using System;
using System.Data;

namespace MovieInformation.Domain
{
    public class Company : Entity
    {


        public Company(string name, DateTime foundedDate, string headquartersLocation, string details)
        {
            Name = name;
            FoundedDate = foundedDate;
            HeadquartersLocation = headquartersLocation;
            Details = details;
        }

        public string Name { get; set; }
        public DateTime FoundedDate { get; set; }
        public string HeadquartersLocation { get; set; }
        public string Details { get; set; }

        public void Update(string name, DateTime foundedDate, string headquartersLocation, string details)
        {
            Name = name;
            FoundedDate = foundedDate;
            HeadquartersLocation = headquartersLocation;
            Details = details;
        }
    }
}