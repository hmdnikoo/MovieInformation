using System.Collections.Generic;

namespace MovieInformation.Domain
{
    public class Movie : Entity
    {
        public Movie(string title, string storyLine, string language)
        {
                Title = title;
                StoryLine = storyLine;
                Language = language;
                Casts = new List<Cast>();
                Producers = new List<Producer>();
                Writers = new List<Writer>();
                Directors = new List<Director>();
                ProductionCompanies = new List<ProductionCompany>();
        }

        public string Title { get; set; }
        public string StoryLine { get; set; }
        public string Language { get; set; }
        public List<ProductionCompany> ProductionCompanies  { get; set; }
        public List<Cast> Casts { get; set; }
        public List<Producer> Producers { get; set; }
        public List<Writer> Writers { get; set; }
        public List<Director> Directors { get; set; }

        public void Update(string title, string storyLine, string language)
        {
            Title = title;
            StoryLine = storyLine;
            Language = language;
        }

        public void AddCast(Cast cast)
        {
            Casts.Add(cast);
        }

        public void AddProducer(Producer producer)
        {
            Producers.Add(producer);
        }

        public void AddWriter(Writer writer)
        {
            Writers.Add(writer);
        }

        public void AddDirector(Director director)
        {
            Directors.Add(director);
        }

        public void AddCompany(ProductionCompany company)
        {
            ProductionCompanies.Add(company);
        }
    }
}