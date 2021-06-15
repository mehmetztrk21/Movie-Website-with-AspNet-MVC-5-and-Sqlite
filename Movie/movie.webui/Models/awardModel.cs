using System.ComponentModel;

namespace movie.webui.Models
{
    public class awardModel
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Başlık")]
        public string name { get; set; }
        public int movieId { get; set; }
    }
}

