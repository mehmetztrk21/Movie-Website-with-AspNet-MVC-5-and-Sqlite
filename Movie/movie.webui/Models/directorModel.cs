using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using movie.entity;

namespace movie.webui.Models
{
    public class directorModel
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("İsim")]
        public string name { get; set; }
        [DisplayName("Özet")]
        public string ozet { get; set; }
        
        [DisplayName("Açıklama")]
        public string description { get; set; }
        [DisplayName("IMDB Linki")]

        public string ımdb { get; set; }
        [DisplayName("Fotoğraf")]

        public string avatar { get; set; }
        [DisplayName("Fotoğraf 2")]

        public string avatar_2 { get; set; }
        public List<Movie> movies { get; set; }
    }
}