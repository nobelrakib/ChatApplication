using System.Threading.Tasks;
using ChatApplication.Data.Entities;
using ChatApplication.Data.DTOs;
using ChatApplication.Data.Helper;

namespace ChatApplication.Data.Repositories
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
    }
}