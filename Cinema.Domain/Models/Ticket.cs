using Cinema.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Domain.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public string? MovieTitle { get; set; }
        public int Row { get; set; }
        public int Seat { get; set; }
        public TicketType TicketType { get; set; }
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; } = DateTime.Now;
        public DateTime Session { get; set; }

        public User? User { get; set; }
    }
}
