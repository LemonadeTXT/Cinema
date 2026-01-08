using AutoMapper;
using Cinema.Application.Interfaces.Repositories;
using Cinema.DAL.Entities;
using Cinema.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IMapper _mapper;

        public UserRepository(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }

        public async Task<User> Get(string email)
        {
            var userEntity = await _applicationContext.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Email == email);

            return _mapper.Map<User>(userEntity);
        }

        public async Task<Guid> Create(User user)
        {
            var userEntity = _mapper.Map<UserEntity>(user);

            await _applicationContext.Users.AddAsync(userEntity);
            await _applicationContext.SaveChangesAsync();

            return userEntity.Id;
        }
    }
}
