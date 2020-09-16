using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformation.Domain
{
    public class Director : Entity
    {
        public Director()
        {
        }
        public Person Person { get; set; }
        public Guid PersonId { get; set; }

        public Movie Movie { get; set; }
        public Guid MovieId { get; set; }
    }
}
