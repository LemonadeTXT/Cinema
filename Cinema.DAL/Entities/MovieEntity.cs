using Cinema.Domain.Enums;

namespace Cinema.DAL.Entities
{
    public class MovieEntity
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public AgeRating AgeRating { get; set; }
        public int FreeSeats { get; set; }
        public DateTime Session { get; set; }
    }
}
