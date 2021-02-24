using System.Collections.Generic;
using System.Threading.Tasks;
using ChatApplication.Data.Entities;
using ChatApplication.Data.DTOs;
using ChatApplication.Data.Helper;

namespace ChatApplication.Data.Repositories
{
    public interface IMessageRepository
    {

        void AddGroup(Group group);
        void RemoveConnection(Connection connection);
        Task<Connection> GetConnection(string connectionId);
        Task<Group> GetMessageGroup(string groupName);
        Task<Group> GetGroupForConnection(string connectionId);
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<MessageDto>> GetMessageThread(string currentUsername, string recipientUsername);
        
    }
}