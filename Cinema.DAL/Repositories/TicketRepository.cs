using Cinema.Application.Interfaces.Repositories;

namespace Cinema.DAL.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ApplicationContext _applicationContext;

        public TicketRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
    }
}
