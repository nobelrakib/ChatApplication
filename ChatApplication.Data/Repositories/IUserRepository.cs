using System.Collections.Generic;
using System.Threading.Tasks;
using ChatApplication.Data.Entities;
using ChatApplication.Data.DTOs;
using ChatApplication.Data.Helper;

namespace ChatApplication.Data.Repositories
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
         Task<MemberDto> GetMemberAsync(string username, bool isCurrentUser);
         Task<string> GetUserGender(string username);
         Task<AppUser> GetUserByPhotoId(int photoId);

    }
}