using System.Threading.Tasks;
using ChatApplication.Data.Repositories;

namespace ChatApplication.Data.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository {get; }
        IMessageRepository MessageRepository {get;}
        ILikesRepository LikesRepository {get; }
        IPhotoRepository PhotoRepository { get; }

        Task<bool> Complete();
        bool HasChanges();
    }
}