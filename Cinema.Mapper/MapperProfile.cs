using AutoMapper;
using Cinema.DAL.Entities;
using Cinema.Domain.Models;

namespace Cinema.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<MovieEntity, Movie>().ReverseMap();
            CreateMap<TicketEntity, Ticket>().ReverseMap();
            CreateMap<UserEntity, User>().ReverseMap();
        }
    }
}
