namespace movie.entity
{
    public class Actor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public string img { get; set; }
        public Movie movie { get; set; }
        public int movie_id { get; set; }
    }
}
