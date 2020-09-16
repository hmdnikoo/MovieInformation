using System.Collections.Generic;

namespace MovieInformation.Domain
{
    public class Person : Entity
    {


        public Person(string firstName, string lastName, string details)
        {
            FirstName = firstName;
            LastName = lastName;
            Details = details;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Details { get; set; }

        public void Update(string firstName, string lastName, string details)
        {
            FirstName = firstName;
            LastName = lastName;
            Details = details;
        }
    }
}