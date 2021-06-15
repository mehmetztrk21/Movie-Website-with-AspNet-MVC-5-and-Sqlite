using System.ComponentModel;
using movie.entity;

namespace movie.webui.Models
{
    public class actorModel
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("İsim ")]
        public string name { get; set; }
        [DisplayName("Açıklama")]
        public string description { get; set; }
        [DisplayName("Fotoğraf")]
        public string img { get; set; }
        public Movie movie { get; set; }
        public int movie_id { get; set; }
    }
}