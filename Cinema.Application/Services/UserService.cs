using AutoMapper;
using Cinema.Application.Interfaces.Auth;
using Cinema.Application.Interfaces.Repositories;
using Cinema.Application.Interfaces.Services;
using Cinema.Common.Auth;
using Cinema.Common.Request;
using Cinema.Domain.Models;

namespace Cinema.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public UserService(
            IUserRepository userRepository, 
            IPasswordHasher passwordHasher, 
            IJwtProvider jwtProvider, 
            IMapper mapper)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<string> Login(AuthUser authUser)
        {
            var user = await _userRepository.Get(authUser.Email);

            var result = _passwordHasher.Verify(authUser.Password, user.PasswordHash);

            if (result == false)
            {
                throw new Exception("Failed to Login");
            }

            var token = _jwtProvider.GenerateToken(user);

            return token;
        }

        public async Task<UserRequest> Get(string email)
        {
            var user = await _userRepository.Get(email);

            return _mapper.Map<UserRequest>(user);
        }

        public async Task<Guid> Create(AuthUser authUser)
        {
            var user = _mapper.Map<User>(authUser);

            user.PasswordHash = _passwordHasher.Generate(authUser.Password);

            return await _userRepository.Create(user);
        }
    }
}
