using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformation.Domain
{
    public class Writer: Entity
    {
        public Writer()
        {
        }

        public Person Person { get; set; }
        public Guid PersonId { get; set; }

        public Movie Movie { get; set; }
        public Guid MovieId { get; set; }
    }
}
