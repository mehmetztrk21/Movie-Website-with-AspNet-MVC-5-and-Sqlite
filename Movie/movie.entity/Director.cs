using System.Collections.Generic;

namespace movie.entity
{
    public class Director
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ozet { get; set; }
        public string description { get; set; }
        public string ımdb { get; set; } 
        public string avatar { get; set; }
        public string avatar_2 { get; set; }
        public List<Movie> movies { get; set; }
    }
}