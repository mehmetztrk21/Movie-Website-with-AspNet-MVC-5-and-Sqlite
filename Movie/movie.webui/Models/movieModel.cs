using System.Collections.Generic;
using System.ComponentModel;
using movie.entity;

namespace movie.webui.Models
{
    public class movieModel
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Film Adı")]
        public string name { get; set; }
        [DisplayName("Özet")]
        public string ozet { get; set; }
        [DisplayName("Açıklama")]
        public string description { get; set; }
        [DisplayName("Fotoğraf")]
        public string img { get; set; }
        [DisplayName("Vizyon Tarihi")]
        public string vizyon { get; set; }
        [DisplayName("IMDB Puanı")]
        public string imdb_puan { get; set; }
        [DisplayName("App Store Link")]
        public string app_store { get; set; }
        [DisplayName("Play Store Link")]
        public string play_store { get; set; }
        [DisplayName("Netflix Link")]
        public string netflix { get; set; }
        [DisplayName("IMDB Link")]
        public string imdb { get; set; }
        [DisplayName("Metacritic Link")]
        public string metacritic { get; set; }
        [DisplayName("Film Süresi")]
        public string süre { get; set; }

        public int director_id { get; set; }
        public Director director { get; set; }
        public List<Actor> actors { get; set; }
        [DisplayName("Fragman Link")]
        public string fragman { get; set; }
        public List<Awards> awards { get; set; }
    }
}