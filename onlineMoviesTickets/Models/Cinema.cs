using System.ComponentModel.DataAnnotations;

namespace onlineMoviesTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Descreption { get; set; }
        public List<Movie> movie { get; set; }
    }
}
