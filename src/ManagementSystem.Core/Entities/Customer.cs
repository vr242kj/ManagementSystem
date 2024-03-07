namespace ManagementSystem.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Country { get; set; }
        public string Status { get; set; } = null!;
    }
}
