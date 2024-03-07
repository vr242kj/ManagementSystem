using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata;

namespace ManagementSystem.Core.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; } = null!;
        public DateTime PublishedOn { get; set; }

        public int TaskId { get; set; } 
        public Task Task { get; set; } = null!;
        public string UserId { get; set; }
        public IdentityUser User { get; set; } = null!;
    }
}
