using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieInformation.API.Models
{
    public class MovieItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string StoryLine { get; set; }
        public string Language { get; set; }
    }
}
