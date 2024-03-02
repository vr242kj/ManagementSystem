using Microsoft.Extensions.Hosting;

namespace ManagementSystem.Core.Entities
{
    public class Case
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? Deadline { get; set; }
        public string Status { get; set; } = null!;

        public User User { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
        public ICollection<Task> Tasks { get; } = new List<Task>();
    }
}
