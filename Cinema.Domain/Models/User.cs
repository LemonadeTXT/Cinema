namespace Cinema.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }

        public List<Ticket>? Tickets { get; set; }
    }
}
