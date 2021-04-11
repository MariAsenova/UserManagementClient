namespace UserManagementClient.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
        }
    }
}