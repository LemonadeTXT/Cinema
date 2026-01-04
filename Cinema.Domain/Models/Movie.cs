using Cinema.Domain.Enums;

namespace Cinema.Domain.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public AgeRating AgeRating { get; set; }
        public int FreeSeats { get; set; }
        public DateTime Session { get; set; }
    }
}
