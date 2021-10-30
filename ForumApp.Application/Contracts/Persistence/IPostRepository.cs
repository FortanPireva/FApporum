using FormumApp.Domain.Entities;

namespace ForumApp.Application.Contracts.Persistence
{
    public interface IPostRepository : IAsyncRepository<Post>
    {
        
    }
}