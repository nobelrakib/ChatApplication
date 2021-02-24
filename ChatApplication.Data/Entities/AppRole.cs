
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
namespace ChatApplication.Data.Entities
{
    public class AppRole : IdentityRole<int>
    {
         public ICollection<AppUserRole> UserRoles { get; set; }
    }
}