using AutoMapper;
using Cinema.Common.Auth;
using Cinema.Common.DTOs;
using Cinema.Common.Request;
using Cinema.Common.Response;
using Cinema.DAL.Entities;
using Cinema.Domain.Models;

namespace Cinema.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Movie, MovieEntity>().ReverseMap();
            CreateMap<Ticket, TicketEntity>().ReverseMap();
            CreateMap<User, UserEntity>().ReverseMap();

            CreateMap<Movie, MovieResponse>().ReverseMap();
            CreateMap<Movie, MovieRequest>().ReverseMap();

            CreateMap<User, AuthUser>().ReverseMap();
            CreateMap<User, UserResponse>().ReverseMap();
            CreateMap<User, UserRequest>().ReverseMap();
        }
    }
}
