namespace AdvDatabase_MusicSystem.Models
{
    public class Songs
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public Albums? Album { get; set; }

        public HashSet<SongContributor> SongContributors { get; set; } = new HashSet<SongContributor>();
        public HashSet<PlaylistSong> PlaylistSong { get; set; } = new HashSet<PlaylistSong>();

        public Songs() { }

        public Songs(string title, int duration, Albums album)
        {
            Title = title;
            Duration = duration;
            Album = album;
        }
    }
}
