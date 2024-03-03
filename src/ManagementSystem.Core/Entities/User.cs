using Microsoft.AspNetCore.Identity;

namespace ManagementSystem.Core.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }

        public ICollection<RecentSearch> RecentSearches { get; } = new List<RecentSearch>();
        public List<Case> Cases { get; } = [];
        public List<Customer> Customers { get; } = [];
        public ICollection<Task> Tasks { get; } = new List<Task>();
        public ICollection<Comment> Comments { get; } = new List<Comment>();
    }
}
