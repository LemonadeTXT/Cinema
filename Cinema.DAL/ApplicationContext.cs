using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cinema.DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<MovieEntity> Movies { get; set; }
        public DbSet<TicketEntity> Tickets { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}
