using System.Reflection.Metadata;

namespace ManagementSystem.Core.Entities
{
    public class RecentSearch
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime SearchedOn { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
