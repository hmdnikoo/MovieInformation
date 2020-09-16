using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformation.Domain
{
    public class Producer : Entity
    {
        public Producer()
        {
        }

        public Person Person { get; set; }
        public Guid PersonId { get; set; }

        public Movie Movie { get; set; }
        public Guid MovieId { get; set; }

    }
}
