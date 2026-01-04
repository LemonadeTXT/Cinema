using AutoMapper;
using Cinema.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace Cinema.Dependencies
{
    public static class Dependencies
    {
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
