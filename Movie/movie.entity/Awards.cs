namespace movie.entity
{
    public class Awards
    {
        public int id { get; set; }
        public string name { get; set; }
        public Movie movie { get; set; }
        public int movieId { get; set; }
    }
}