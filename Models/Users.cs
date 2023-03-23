namespace AdvDatabase_MusicSystem.Models
{
    public class Users
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public Users() { }
        public Users(string username)
        {
            UserName = username;
        }
    }
}
