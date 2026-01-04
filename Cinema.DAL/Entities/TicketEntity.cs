using Cinema.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.DAL.Entities
{
    public class TicketEntity
    {
        public Guid Id { get; set; }
        public string? MovieTitle { get; set; }
        public int Row { get; set; }
        public int Seat { get; set; }
        public TicketType TicketType { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set;  }
        public DateTime Session { get; set; }

        public UserEntity? UserEntity { get; set; }
    }
}
