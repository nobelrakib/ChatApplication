using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using API.Helper;

namespace API.Extentions
{
    public static class ApplicationServiceExtentions
    {
        public static  IServiceCollection AddApplicationService(this IServiceCollection services,IConfiguration config)
        {
            services.Configure<CloudinarySettings>(config.GetSection("CloudnarySettings"));
            services.AddScoped<IPhotoService,PhotoService>();
            services.AddDbContext<DataContext>(options=>{
                    options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddScoped<IUserRepository,UserRepository>();
            services.AddScoped<ITokenService,TokenService>();
            
            return services;
        }

       
    }
}