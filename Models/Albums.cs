namespace AdvDatabase_MusicSystem.Models
{
    public class Albums
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Albums() { }

        public Albums(string title) {
            Title = title;
        }
    }
}
