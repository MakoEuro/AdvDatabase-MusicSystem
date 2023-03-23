using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdvDatabase_MusicSystem.Models;

namespace AdvDatabase_MusicSystem.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<AdvDatabase_MusicSystem.Models.Albums> Albums { get; set; } = default!;
        public DbSet<AdvDatabase_MusicSystem.Models.Songs> Songs { get; set; } = default!;
        public DbSet<AdvDatabase_MusicSystem.Models.Artists> Artists { get; set; } = default!;
        public DbSet<AdvDatabase_MusicSystem.Models.Playlists> Playlists { get; set; } = default!;
        public DbSet<AdvDatabase_MusicSystem.Models.SongContributor> SongContributors { get; set; } = default!;
        public DbSet<AdvDatabase_MusicSystem.Models.PlaylistSong> PlaylistSong { get; set; } = default!;
    }
}
