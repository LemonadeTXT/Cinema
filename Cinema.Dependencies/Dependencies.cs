using AutoMapper;
using Cinema.Application.Interfaces.Repositories;
using Cinema.Application.Interfaces.Services;
using Cinema.Application.Services;
using Cinema.DAL.Repositories;
using Cinema.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace Cinema.Dependencies
{
    public static class Dependencies
    {
        public static void AddIServices(this IServiceCollection services)
        {
            services.AddTransient<IMovieService, MovieService>();
        }

        public static void AddIRepositories(this IServiceCollection services)
        {
            services.AddTransient<IMovieRepository, MovieRepository>();
            services.AddTransient<ITicketRepository, TicketRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
        }

        public static void AddIMapper(this IServiceCollection services)
        {
            var mapConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });

            var mapper = mapConfig.CreateMapper();

            services.AddSingleton(mapper);
        }
    }
}
