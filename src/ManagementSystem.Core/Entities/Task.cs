using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace ManagementSystem.Core.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Type { get; set; } = null!;
        public DateTime Deadline { get; set; }
        public string ClassOfPriority { get; set; } = null!;

        public int UserId { get; set; } 
        public User User { get; set; } = null!;
        public int CaseId { get; set; }
        public User Case { get; set; } = null!;
        public ICollection<Comment> Comments { get; } = new List<Comment>();
    }
}
