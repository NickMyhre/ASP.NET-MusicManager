using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusicManager.Models.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasData(
                new Artist
                {
                    Id = 1,
                    StageName = null,
                    BirthName = "Chris Cornell",
                    Hometown = "Seattle",
                    BirthDate = DateTime.Parse("1964 - 07 - 18 00:00:00"),
                    DeathDate = DateTime.Parse("2017-05-18 00:00:00"),
                    Fact = "Lead Singer in Soundgarden"
                },
    new Artist
    {
        Id = 2,
        StageName = null,
        BirthName = "Bruce Springsteen",
        Hometown = "New Jersey",
        BirthDate = DateTime.Parse("1949-09-23 00:00:00"),
        DeathDate = null,
        Fact = "Dedicated an album to 9/11 victims"
    },
    new Artist
    {
        Id = 3,
        StageName = "Freddie Mercury",
        BirthName = "Farrokh Bulsara",
        Hometown = "Sultanate",
        BirthDate = DateTime.Parse("1946-09-05 00:00:00"),
        DeathDate = DateTime.Parse("1991-11-24 00:00:00"),
        Fact = "Born in Zanzibar"
    },
    new Artist
    {
        Id = 4,
        StageName = "The Man in Black",
        BirthName = "Johnny Cash",
        Hometown = "Kingsland",
        BirthDate = DateTime.Parse("1932-02-26 00:00:00"),
        DeathDate = DateTime.Parse("2003-09-12 00:00:00"),
        Fact = "Covered a Nine-Inch Nails Song"
    },
    new Artist
    {
        Id = 5,
        StageName = "Papa Roach",
        BirthName = "Jacoby Shaddix",
        Hometown = "Vacaville",
        BirthDate = DateTime.Parse("1976-07-28 00:00:00"),
        DeathDate = null,
        Fact = "Host of Scarred"
    },
    new Artist
    {
        Id = 6,
        StageName = "Grandson",
        BirthName = "Jordan Benjamin",
        Hometown = "Toronto",
        BirthDate = DateTime.Parse("1993-10-25 00:00:00"),
        DeathDate = null,
        Fact = "Canadian dude"
    },
    new Artist
    {
        Id = 7,
        StageName = null,
        BirthName = "Frank Sinatra",
        Hometown = "Hoboken",
        BirthDate = DateTime.Parse("1915-12-12 00:00:00"),
        DeathDate = DateTime.Parse("1998-05-14 00:00:00"),
        Fact = "Lived in a rat-infested shed"
    },
    new Artist
    {
        Id = 8,
        StageName = "Beck",
        BirthName = "Bek Cambell",
        Hometown = "Los Angelas",
        BirthDate = DateTime.Parse("1970-07-08 00:00:00"),
        DeathDate = null,
        Fact = "Host of Scarred"
    });
        }
    }
}
