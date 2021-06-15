using System.Collections.Generic;

namespace movie.entity
{
    public class Movie
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ozet { get; set; }
        public string description { get; set; }
        public string img { get; set; }
        public string vizyon { get; set; }
        public string imdb_puan { get; set; }
        public string app_store { get; set; }
        public string play_store { get; set; }
        public string netflix { get; set; }
        public string imdb { get; set; }
        public string metacritic { get; set; }
        public int director_id { get; set; }
        public string director_name { get; set; }
        public string süre { get; set; }
        public Director director { get; set; }
        public List<Actor> actors { get; set; }
        public string fragman { get; set; }
        public List<Awards> awards { get; set; }
    }
}