using System.Collections.Generic;
using System.Threading.Tasks;
using ChatApplication.Data.DTOs;
using ChatApplication.Data.Entities;

namespace ChatApplication.Data.Repositories
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<PhotoForApprovalDto>> GetUnapprovedPhotos();
        Task<Photo> GetPhotoById(int id);
        void RemovePhoto(Photo photo);
    }
}