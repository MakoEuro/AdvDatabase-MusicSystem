using Microsoft.Identity.Client;

namespace AdvDatabase_MusicSystem.Models
{
    public class Playlists
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public HashSet<PlaylistSong> PlaylistSong { get; set; } = new HashSet<PlaylistSong>();

        public Playlists() { }

        public Playlists(string name)
        {
            Name = name;
        }
    }
}

