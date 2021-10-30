using FormumApp.Domain.Entities;

namespace ForumApp.Application.Contracts.Persistence
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        public User GetUserByEmail(string email);
        public User GetUserByUsername(string username);
    }
}