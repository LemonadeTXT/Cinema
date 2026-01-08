using AutoMapper;
using Cinema.Application.Interfaces.Repositories;
using Cinema.Application.Interfaces.Services;
using Cinema.Common.Request;
using Cinema.Common.Response;
using Cinema.Domain.Models;

namespace Cinema.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserRequest> Get(string email)
        {
            var user = await _userRepository.Get(email);

            return _mapper.Map<UserRequest>(user);
        }

        public async Task<Guid> Create(UserResponse userResponse)
        {
            var user = _mapper.Map<User>(userResponse);
            
            return await _userRepository.Create(user);
        }
    }
}
