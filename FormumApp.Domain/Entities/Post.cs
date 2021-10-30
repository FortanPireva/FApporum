namespace FormumApp.Domain.Entities
{
    public class Post : BaseEntity
    {
        public string Name { get; set; }
        public string Description   { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}