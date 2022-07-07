namespace Chat_App.Models
{
    public class User
    {
        public int Id { get; set; }
        public Gender Gender { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public ICollection<User> Friends { get; set; } = new List<User>();
    }
}
