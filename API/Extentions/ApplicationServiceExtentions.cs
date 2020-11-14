using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extentions
{
    public static class ApplicationServiceExtentions
    {
        public static  IServiceCollection AddApplicationService(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<DataContext>(options=>{
                    options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<ITokenService,TokenService>();
            
            return services;
        }

       
    }
}