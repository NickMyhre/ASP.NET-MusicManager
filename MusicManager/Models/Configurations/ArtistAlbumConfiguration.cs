using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusicManager.Models.Configurations
{
    public class ArtistAlbumConfiguration : IEntityTypeConfiguration<ArtistAlbum>
    {
        public void Configure(EntityTypeBuilder<ArtistAlbum> builder)
        {
            builder.HasData(
                new ArtistAlbum
                {
                    ArtistId = 1,
                    AlbumId = 1
                },
                new ArtistAlbum
                {
                    ArtistId = 1,
                    AlbumId = 2
                },
                new ArtistAlbum
                {
                    ArtistId = 2,
                    AlbumId = 3
                },
                new ArtistAlbum
                {
                    ArtistId = 3,
                    AlbumId = 4
                },
                new ArtistAlbum
                {
                    ArtistId = 4,
                    AlbumId = 5

                },
                new ArtistAlbum
                {
                    ArtistId = 4,
                    AlbumId = 6
                },
                new ArtistAlbum
                {
                    ArtistId = 5,
                    AlbumId = 7
                },
                new ArtistAlbum
                {
                    ArtistId = 6,
                    AlbumId = 8
                },
                new ArtistAlbum
                {
                    ArtistId = 7,
                    AlbumId = 9 
                },
                new ArtistAlbum
                {
                    ArtistId = 8,
                    AlbumId = 10

                },
                new ArtistAlbum
                {
                    ArtistId = 4,
                    AlbumId = 11
                },
                new ArtistAlbum
                {
                    ArtistId = 8,
                    AlbumId = 12
                });
        }
    }
}
