using System.ComponentModel.DataAnnotations.Schema;

namespace onlineMoviesTickets.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descreption { get; set; }
        public double price { get; set; }
        public string ImageURL { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public List<Actor_Movie> Actor_Movies { get; set; }
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producers { get; set; }
        
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema cinemas { get; set; }

        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public MovieCategory MovieCategory { get; set; }

    }
}
