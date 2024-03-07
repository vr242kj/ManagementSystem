using Microsoft.AspNetCore.Identity;

namespace ManagementSystem.Core.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public ICollection<RecentSearch> RecentSearches { get; } = new List<RecentSearch>();
        public List<Case> Cases { get; } = new List<Case>();
        public List<Customer> Customers { get; } = new List<Customer>();
        public ICollection<Task> Tasks { get; } = new List<Task>();
        public ICollection<Comment> Comments { get; } = new List<Comment>();
    }
}
