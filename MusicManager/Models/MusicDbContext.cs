using Microsoft.EntityFrameworkCore;
using MusicManager.Models.Configurations;

namespace MusicManager.Models
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistSong> ArtistSongs { get; set; }
        public DbSet<ArtistAlbum> ArtistAlbums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArtistSong>().HasKey(e => new { e.ArtistId, e.SongId });
            modelBuilder.Entity<ArtistAlbum>().HasKey(e => new { e.ArtistId, e.AlbumId });
            modelBuilder.Entity<Song>()
            .HasMany(b => b.Artists)
            .WithMany(c => c.Songs)
            ;

            modelBuilder.Entity<Album>()
            .HasMany(b => b.Artists)
            .WithMany(c => c.Albums)
            .UsingEntity(j => j.ToTable("ArtistAlbum"));

            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new AlbumConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistSongConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistAlbumConfiguration());
        }
    }
}
