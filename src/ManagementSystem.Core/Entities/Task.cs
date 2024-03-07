
using Microsoft.AspNetCore.Identity;

namespace ManagementSystem.Core.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Type { get; set; }
        public DateTime Deadline { get; set; }
        public string ClassOfPriority { get; set; } = null!;

        public string UserId { get; set; } 
        public IdentityUser User { get; set; }
        public int CaseId { get; set; }
        public Case Case { get; set; } = null!;
        public ICollection<Comment> Comments { get; } = new List<Comment>();
    }
}
