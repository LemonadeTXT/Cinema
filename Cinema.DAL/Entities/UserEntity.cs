namespace Cinema.DAL.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }

        public List<TicketEntity>? TicketEntities { get; set; }
    }
}
