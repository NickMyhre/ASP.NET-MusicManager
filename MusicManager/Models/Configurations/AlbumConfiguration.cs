using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusicManager.Models.Configurations
{
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasData(
                new Album
                {
                    Id = 1,
                    Title = "Higher Truth",
                    Label = "UME",
                    Genre = "Alternative",
                    ReleaseDate = DateTime.Parse("9/18/2015 12:00:00 AM"),
                    Fact = "positive album"
                },
                new Album
                {
                    Id = 2,
                    Title = "No One Sings Like You Anymore, Vol. 1",
                    Label = "UME",
                    Genre = "Alternative",
                    ReleaseDate = DateTime.Parse("12/11/2020 12:00:00 AM"),
                    Fact = "released after death"
                },
                new Album
                {
                    Id = 3,
                    Title = "The Wild, the Innocent, & the E Street Shuffle",
                    Label = "Columbia",
                    Genre = "Rock and Roll",
                    ReleaseDate = DateTime.Parse("11/5/1973 12:00:00 AM"),
                    Fact = "Second album by Mr. Bruce"
                },
                new Album
                {
                    Id = 4,
                    Title = "Mr. Bad Guy",
                    Label = "Columbia",
                    Genre = "Synth-Pop",
                    ReleaseDate = DateTime.Parse("4/29/1985 12:00:00 AM"),
                    Fact = "Was supposed to have duets with Michael Jackson"
                },
                new Album
                {
                    Id = 5,
                    Title = "Ride This Train",
                    Label = "Columbia",
                    Genre = "Country",
                    ReleaseDate = DateTime.Parse("8/1/1960 12:00:00 AM"),
                    Fact = "First concept album"
                },
                new Album
                {
                    Id = 6,
                    Title = "Blood, Sweat, and Tears",
                    Label = "Legacy",
                    Genre = "Country",
                    ReleaseDate = DateTime.Parse("1/7/1963 12:00:00 AM"),
                    Fact = "About the american working man"
                },
                new Album
                {
                    Id = 7,
                    Title = "Infest",
                    Label = "DreamWorks",
                    Genre = "Alternative",
                    ReleaseDate = DateTime.Parse("4/25/2000 12:00:00 AM"),
                    Fact = "Nasty cover photo"
                },
                new Album
                {
                    Id = 8,
                    Title = "Death of an Optimist",
                    Label = "Fueled by Ramen",
                    Genre = "Alternative",
                    ReleaseDate = DateTime.Parse("12/4/2020 12:00:00 AM"),
                    Fact = "Third album from the dude"
                },
                new Album
                {
                    Id = 9,
                    Title = "The Voice of Frank Sinatra",
                    Label = "Columbia",
                    Genre = "Traditional Pop",
                    ReleaseDate = DateTime.Parse("5/4/1946 12:00:00 AM"),
                    Fact = null
                },
                new Album
                {
                    Id = 10,
                    Title = "Colors",
                    Label = "Capitol",
                    Genre = "Pop",
                    ReleaseDate = DateTime.Parse("10/13/2017 12:00:00 AM"),
                    Fact = "The thirteenth Beck album"
                },
                new Album
                {
                    Id = 11,
                    Title = "Five Feet High and Rising",
                    Label = "Columbia",
                    Genre = "Country",
                    ReleaseDate = DateTime.Parse("1/1/1974 12:00:00 AM"),
                    Fact = "Release date month and day is a little ambiguous"
                },
                new Album
                {
                    Id = 12,
                    Title = "Mellow Gold",
                    Label = "DGC",
                    Genre = "Alternative",
                    ReleaseDate = DateTime.Parse("3/1/1994 12:00:00 AM"),
                    Fact = "Like a satanic K-tel record thats been found in a trash dumpster"
                });
        }
    }
}
