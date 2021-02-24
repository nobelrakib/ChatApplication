using System;
using System.Threading.Tasks;
using ChatApplication.API.Extentions;
using ChatApplication.Data.UnitOfWorks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace ChatApplication.API.Filter
{
    public class LogUserActivity :IAsyncActionFilter
    {
           public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
           {
            var resultContext = await next();
            

            if (!resultContext.HttpContext.User.Identity.IsAuthenticated) return;
            var userId = resultContext.HttpContext.User.GetUserId();
            var uow = resultContext.HttpContext.RequestServices.GetService<IUnitOfWork>();
            var user = await uow.UserRepository.GetUserByIdAsync(userId);
            user.LastActive = DateTime.UtcNow;
            await uow.Complete();
           
           }
    }
}