using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surename { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;

        public ICollection<RecentSearch> RecentSearches { get; } = new List<RecentSearch>();
        public List<Case> Cases { get; } = [];
        public List<Customer> Customers { get; } = [];
        public ICollection<Task> Tasks { get; } = new List<Task>();
        public ICollection<Comment> Comments { get; } = new List<Comment>();
    }
}
