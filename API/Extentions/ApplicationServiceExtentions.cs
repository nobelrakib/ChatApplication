using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using API.Helper;
using API.SignalIR;

namespace API.Extentions
{
    public static class ApplicationServiceExtentions
    {
        public static  IServiceCollection AddApplicationService(this IServiceCollection services,IConfiguration config)
        {
            services.AddSingleton<PresenceTracker>();
            services.Configure<CloudinarySettings>(config.GetSection("CloudnarySettings"));
            services.AddScoped<IPhotoService,PhotoService>();
            services.AddDbContext<DataContext>(options=>{
                    options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddScoped<LogUserActivity>();
            services.AddScoped<ITokenService,TokenService>();
            
            return services;
        }

       
    }
}