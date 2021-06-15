using System.Collections.Generic;
using movie.entity;

namespace movie.webui.Models
{
    public class GenericModel
    {
        public List<Director> directors { get; set; }
        public List<Actor> actors { get; set; }
        public List<Awards> awards { get; set; }
        public List<Movie> movies { get; set; }
        public Director director{get;set;}
        public Movie movie{get;set;}

    }
}