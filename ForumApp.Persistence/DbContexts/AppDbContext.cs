using FormumApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Persistence.DbContexts
{
    public class AppDbContext : DbContext

    {
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }
    }
}