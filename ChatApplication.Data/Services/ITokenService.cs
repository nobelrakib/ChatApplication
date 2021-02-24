using System.Threading.Tasks;
using ChatApplication.Data.Entities;

namespace ChatApplication.Data.Services
{
    public interface ITokenService
    {
       Task<string> CreateToken(AppUser user);
    }
}