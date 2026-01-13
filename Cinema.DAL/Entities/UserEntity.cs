using Cinema.Domain.Enums;

namespace Cinema.DAL.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public UserRole Role { get; set; }

        public List<TicketEntity>? TicketEntities { get; set; }
    }
}
