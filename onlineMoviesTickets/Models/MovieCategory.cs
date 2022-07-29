namespace onlineMoviesTickets.Models
{
    public class MovieCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
