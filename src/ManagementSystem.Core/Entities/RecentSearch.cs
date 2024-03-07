using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata;

namespace ManagementSystem.Core.Entities
{
    public class RecentSearch
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime SearchedOn { get; set; }

        public string UserId { get; set; }
        public IdentityUser User { get; set; } = null!;
    }
}
