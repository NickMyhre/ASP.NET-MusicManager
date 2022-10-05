using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusicManager.Models.Configurations
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasData(
                new Song
                {
                    Id = 1,
                    Name = "Nearly Forgot My Broken Heart",
                    Length = TimeSpan.Parse("00:03:54"),
                    Comment = "Good Song",
                    BillBoardRank = 18,
                    BillBoardDate = DateTime.Parse("12/26/2015 12:00:00 AM"),
                    Writer = "Chris Cornell",
                    AlbumId = 1
                },
                new Song
                {
                    Id = 2,
                    Name = "Dead Wishes",
                    Length = TimeSpan.Parse("00:03:54"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Chris Cornell",
                    AlbumId = 1
                },
                new Song
                {
                    Id = 3,
                    Name = "Worried Moon",
                    Length = TimeSpan.Parse("00:04:32"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Chris Cornell",
                    AlbumId = 1
                },
                new Song
                {
                    Id = 4,
                    Name = "Before We Disappear",
                    Length = TimeSpan.Parse("00:03:51"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Chris Cornell",
                    AlbumId = 1
                },
                new Song
                {
                    Id = 5,
                    Name = "Through the Window",
                    Length = TimeSpan.Parse("00:04:41"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Chris Cornell",
                    AlbumId = 1
                },
                new Song
                {
                    Id = 6,
                    Name = "Josephine",
                    Length = TimeSpan.Parse("00:03:38"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Chris Cornell",
                    AlbumId = 1
                },
                new Song
                {
                    Id = 7,
                    Name = "Murderer of Blue Skies",
                    Length = TimeSpan.Parse("00:03:42"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Chris Cornell",
                    AlbumId = 1
                },
                new Song
                {
                    Id = 8,
                    Name = "Higher Truth",
                    Length = TimeSpan.Parse("00:05:06"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Chris Cornell",
                    AlbumId = 1
                },
                new Song
                {
                    Id = 9,
                    Name = "Let Your Eyes Wander",
                    Length = TimeSpan.Parse("00:03:42"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Chris Cornell",
                    AlbumId = 1
                },
                new Song
                {
                    Id = 10,
                    Name = "Only These Words",
                    Length = TimeSpan.Parse("00:03:29"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Chris Cornell",
                    AlbumId = 1
                },
                new Song
                {
                    Id = 11,
                    Name = "Circling",
                    Length = TimeSpan.Parse("00:03:28"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Chris Cornell",
                    AlbumId = 1
                },
                new Song
                {
                    Id = 12,
                    Name = "Our Time in the Universe",
                    Length = TimeSpan.Parse("00:04:19"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Chris Cornell",
                    AlbumId = 1
                },
                new Song
                {
                    Id = 13,
                    Name = "Get It While You Can",
                    Length = TimeSpan.Parse("00:03:22"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Jerry Ragovoy",
                    AlbumId = 2
                },
                new Song
                {
                    Id = 14,
                    Name = "Jump into the Fire",
                    Length = TimeSpan.Parse("00:03:35"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Harry Nilsson",
                    AlbumId = 2
                },
                new Song
                {
                    Id = 15,
                    Name = "Sad Sad City",
                    Length = TimeSpan.Parse("00:03:49"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Aaron Behrens",
                    AlbumId = 2
                },
                new Song
                {
                    Id = 16,
                    Name = "Patience",
                    Length = TimeSpan.Parse("00:04:13"),
                    Comment = "Havent Heard",
                    BillBoardRank = 25,
                    BillBoardDate = DateTime.Parse("11/14/2020 12:00:00 AM"),
                    Writer = "Guns N Roses",
                    AlbumId = 2
                },
                new Song
                {
                    Id = 17,
                    Name = "Nothing Compares 2 U",
                    Length = TimeSpan.Parse("00:04:12"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Prince",
                    AlbumId = 2
                },
                new Song
                {
                    Id = 18,
                    Name = "Watching the Wheels",
                    Length = TimeSpan.Parse("00:03:14"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "John Lennon",
                    AlbumId = 2
                },
                new Song
                {
                    Id = 19,
                    Name = "You Dont Know Nothing About Love",
                    Length = TimeSpan.Parse("00:03:04"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Jerry Ragovoy",
                    AlbumId = 2
                },
                new Song
                {
                    Id = 20,
                    Name = "Showdown",
                    Length = TimeSpan.Parse("00:03:23"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Jeff Lynne",
                    AlbumId = 2
                },
                new Song
                {
                    Id = 21,
                    Name = "To Be Treated Rite",
                    Length = TimeSpan.Parse("00:03:14"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Terry Reid",
                    AlbumId = 2
                },
                new Song
                {
                    Id = 22,
                    Name = "Stay with Me Baby",
                    Length = TimeSpan.Parse("00:04:15"),
                    Comment = "Havent Heard",
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Jerry Ragovoy",
                    AlbumId = 2
                },
                new Song
                {
                    Id = 23,
                    Name = "The E Street Shuffle",
                    Length = TimeSpan.Parse("00:04:31"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Bruce Springsteen",
                    AlbumId = 3
                },
                new Song
                {
                    Id = 24,
                    Name = "4th of July, Asbury Park(Sandy)",
                    Length = TimeSpan.Parse("00:05:36"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Bruce Springsteen",
                    AlbumId = 3
                },
                new Song
                {
                    Id = 25,
                    Name = "Kittys Back",
                    Length = TimeSpan.Parse("00:07:09"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Bruce Springsteen",
                    AlbumId = 3
                },
                new Song
                {
                    Id = 26,
                    Name = "Wild Billys Circus Story",
                    Length = TimeSpan.Parse("00:04:47"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Bruce Springsteen",
                    AlbumId = 3
                },
                new Song
                {
                    Id = 27,
                    Name = "Incident on 57th Street",
                    Length = TimeSpan.Parse("00:07:45"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Bruce Springsteen",
                    AlbumId = 3
                },
                new Song
                {
                    Id = 28,
                    Name = "Rosalita (Come Out Tonight)",
                    Length = TimeSpan.Parse("00:07:04"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Bruce Springsteen",
                    AlbumId = 3
                },
                new Song
                {
                    Id = 29,
                    Name = "New York City Seranade",
                    Length = TimeSpan.Parse("00:09:55"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Bruce Springsteen",
                    AlbumId = 3
                },
                new Song
                {
                    Id = 30,
                    Name = "Lets Turn It On",
                    Length = TimeSpan.Parse("00:03:42"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Freddie Mercury",
                    AlbumId = 4
                },
                new Song
                {
                    Id = 31,
                    Name = "Made in Heaven",
                    Length = TimeSpan.Parse("00:04:05"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Freddie Mercury",
                    AlbumId = 4
                },
                new Song
                {
                    Id = 32,
                    Name = "I Was Born to Love You",
                    Length = TimeSpan.Parse("00:03:38"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Freddie Mercury",
                    AlbumId = 4
                },
                new Song
                {
                    Id = 33,
                    Name = "Foolin Around",
                    Length = TimeSpan.Parse("00:03:29"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Freddie Mercury",
                    AlbumId = 4
                },
                new Song
                {
                    Id = 34,
                    Name = "Your Kind of Lover",
                    Length = TimeSpan.Parse("00:03:32"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Freddie Mercury",
                    AlbumId = 4
                },
                new Song
                {
                    Id = 35,
                    Name = "Mr. Bad Guy",
                    Length = TimeSpan.Parse("00:04:09"),
                    Comment = null,
                    BillBoardRank = 159,
                    BillBoardDate = DateTime.Parse("6/15/1985 12:00:00 AM"),
                    Writer = "Freddie Mercury",
                    AlbumId = 4
                },
                new Song
                {
                    Id = 36,
                    Name = "Man Made Paradise",
                    Length = TimeSpan.Parse("00:04:08"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Freddie Mercury",
                    AlbumId = 4
                },
                new Song
                {
                    Id = 37,
                    Name = "There Must Be More to Life Than This",
                    Length = TimeSpan.Parse("00:03:00"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Freddie Mercury",
                    AlbumId = 4
                },
                new Song
                {
                    Id = 38,
                    Name = "My Love is Dangerous",
                    Length = TimeSpan.Parse("00:03:42"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Freddie Mercury",
                    AlbumId = 4
                },
                new Song
                {
                    Id = 39,
                    Name = "Love Me Like Theres No Tomorrow",
                    Length = TimeSpan.Parse("00:03:46"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Freddie Mercury",
                    AlbumId = 4
                },
                new Song
                {
                    Id = 40,
                    Name = "Living on My Own",
                    Length = TimeSpan.Parse("00:03:42"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Freddie Mercury",
                    AlbumId = 4
                },
                new Song
                {
                    Id = 41,
                    Name = "Loading Coal",
                    Length = TimeSpan.Parse("00:04:58"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Merle Travis",
                    AlbumId = 5
                },
                new Song
                {
                    Id = 42,
                    Name = "Slow Rider",
                    Length = TimeSpan.Parse("00:04:12"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Johnny Cash",
                    AlbumId = 5
                },
                new Song
                {
                    Id = 43,
                    Name = "Lumberjack",
                    Length = TimeSpan.Parse("00:03:02"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Leon Payne",
                    AlbumId = 5
                },
                new Song
                {
                    Id = 44,
                    Name = "Dorraine of Ponchartrain",
                    Length = TimeSpan.Parse("00:04:47"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Cash",
                    AlbumId = 5
                },
                new Song
                {
                    Id = 45,
                    Name = "Going to Memphis",
                    Length = TimeSpan.Parse("00:04:26"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Hollie Dew",
                    AlbumId = 5
                },
                new Song
                {
                    Id = 46,
                    Name = "When Papa Played the Dobro",
                    Length = TimeSpan.Parse("00:02:55"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Cash",
                    AlbumId = 5
                },
                new Song
                {
                    Id = 47,
                    Name = "Boss Jack",
                    Length = TimeSpan.Parse("00:03:50"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Tex Ritter",
                    AlbumId = 5
                },
                new Song
                {
                    Id = 48,
                    Name = "Old Doc Brown",
                    Length = TimeSpan.Parse("00:04:10"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Red Foley",
                    AlbumId = 5
                },
                new Song
                {
                    Id = 49,
                    Name = "The Legend of John Henrys Hammer",
                    Length = TimeSpan.Parse("00:09:03"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Johnny Cash",
                    AlbumId = 6
                },
                new Song
                {
                    Id = 50,
                    Name = "Tell Him Im Gone",
                    Length = TimeSpan.Parse("00:03:03"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Cash",
                    AlbumId = 6
                },
                new Song
                {
                    Id = 51,
                    Name = "Another Man Done Gone",
                    Length = TimeSpan.Parse("00:02:35"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Vera Hall",
                    AlbumId = 6
                },
                new Song
                {
                    Id = 52,
                    Name = "Busted",
                    Length = TimeSpan.Parse("00:02:17"),
                    Comment = null,
                    BillBoardRank = 13,
                    BillBoardDate = DateTime.Parse("1/1/1963 12:00:00 AM"),
                    Writer = "Harlan Howard",
                    AlbumId = 6
                },
                new Song
                {
                    Id = 53,
                    Name = "Casey Jones",
                    Length = TimeSpan.Parse("00:03:02"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Cash",
                    AlbumId = 6
                },
                new Song
                {
                    Id = 54,
                    Name = "Nine Pound Hammer",
                    Length = TimeSpan.Parse("00:03:15"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Merle Travis",
                    AlbumId = 6
                },
                new Song
                {
                    Id = 55,
                    Name = "Chain Gang",
                    Length = TimeSpan.Parse("00:02:40"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Howard",
                    AlbumId = 6
                },
                new Song
                {
                    Id = 56,
                    Name = "Waiting for a Train",
                    Length = TimeSpan.Parse("00:02:06"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Jimmie Rogers",
                    AlbumId = 6
                },
                new Song
                {
                    Id = 57,
                    Name = "Roughneck",
                    Length = TimeSpan.Parse("00:02:11"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Sheb Wooley",
                    AlbumId = 6
                },
                new Song
                {
                    Id = 58,
                    Name = "Infest",
                    Length = TimeSpan.Parse("00:04:09"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Papa Roach",
                    AlbumId = 7
                },
                new Song
                {
                    Id = 59,
                    Name = "Last Resort",
                    Length = TimeSpan.Parse("00:03:19"),
                    Comment = null,
                    BillBoardRank = 1,
                    BillBoardDate = DateTime.Parse("8/12/2000 12:00:00 AM"),
                    Writer = "Papa Roach",
                    AlbumId = 7
                },
                new Song
                {
                    Id = 60,
                    Name = "Broken Home",
                    Length = TimeSpan.Parse("00:03:41"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Papa Roach",
                    AlbumId = 7
                },
                new Song
                {
                    Id = 61,
                    Name = "Dead Cell",
                    Length = TimeSpan.Parse("00:03:06"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Papa Roach",
                    AlbumId = 7
                },
                new Song
                {
                    Id = 62,
                    Name = "Between Angels and Insects",
                    Length = TimeSpan.Parse("00:03:54"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Papa Roach",
                    AlbumId = 7
                },
                new Song
                {
                    Id = 63,
                    Name = "Blood Brothers",
                    Length = TimeSpan.Parse("00:03:34"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Papa Roach",
                    AlbumId = 7
                },
                new Song
                {
                    Id = 64,
                    Name = "Revenge",
                    Length = TimeSpan.Parse("00:03:42"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Papa Roach",
                    AlbumId = 7
                },
                new Song
                {
                    Id = 65,
                    Name = "Snakes",
                    Length = TimeSpan.Parse("00:03:29"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Papa Roach",
                    AlbumId = 7
                },
                new Song
                {
                    Id = 66,
                    Name = "Never Enough",
                    Length = TimeSpan.Parse("00:03:35"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Papa Roach",
                    AlbumId = 7
                },
                new Song
                {
                    Id = 67,
                    Name = "Binge",
                    Length = TimeSpan.Parse("00:03:47"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Papa Roach",
                    AlbumId = 7
                },
                new Song
                {
                    Id = 68,
                    Name = "Thrown Away",
                    Length = TimeSpan.Parse("00:09:36"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Papa Roach",
                    AlbumId = 7
                },
                new Song
                {
                    Id = 69,
                    Name = "Death of an Optimist // Intro",
                    Length = TimeSpan.Parse("00:02:31"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Grandson",
                    AlbumId = 8
                },
                new Song
                {
                    Id = 70,
                    Name = "In Over My Head",
                    Length = TimeSpan.Parse("00:03:18"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Grandson",
                    AlbumId = 8
                },
                new Song
                {
                    Id = 71,
                    Name = "Identity",
                    Length = TimeSpan.Parse("00:03:36"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Grandson",
                    AlbumId = 8
                },
                new Song
                {
                    Id = 72,
                    Name = "Left Behind",
                    Length = TimeSpan.Parse("00:03:25"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Grandson",
                    AlbumId = 8
                },
                new Song
                {
                    Id = 73,
                    Name = "Dirty",
                    Length = TimeSpan.Parse("00:03:28"),
                    Comment = null,
                    BillBoardRank = 10,
                    BillBoardDate = DateTime.Parse("2/27/2021 12:00:00 AM"),
                    Writer = "Grandson",
                    AlbumId = 8
                },
                new Song
                {
                    Id = 74,
                    Name = "The Ballad of G and X // Interlude",
                    Length = TimeSpan.Parse("00:02:22"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Grandson",
                    AlbumId = 8
                },
                new Song
                {
                    Id = 75,
                    Name = "We Did It!!!",
                    Length = TimeSpan.Parse("00:02:49"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Grandson",
                    AlbumId = 8
                },
                new Song
                {
                    Id = 76,
                    Name = "WWIII",
                    Length = TimeSpan.Parse("00:03:22"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Grandson",
                    AlbumId = 8
                },
                new Song
                {
                    Id = 77,
                    Name = "Riptide",
                    Length = TimeSpan.Parse("00:03:12"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Grandson",
                    AlbumId = 8
                },
                new Song
                {
                    Id = 78,
                    Name = "Pain Shopping",
                    Length = TimeSpan.Parse("00:03:17"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Grandson",
                    AlbumId = 8
                },
                new Song
                {
                    Id = 79,
                    Name = "Drop Dead",
                    Length = TimeSpan.Parse("00:03:09"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Grandson",
                    AlbumId = 8
                },
                new Song
                {
                    Id = 80,
                    Name = "Welcome to Paradise // Outro",
                    Length = TimeSpan.Parse("00:03:31"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Grandson",
                    AlbumId = 8
                },
                new Song
                {
                    Id = 81,
                    Name = "You Go to My Head",
                    Length = TimeSpan.Parse("00:03:00"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Axel Stordahl",
                    AlbumId = 9
                },
                new Song
                {
                    Id = 82,
                    Name = "Someone to Watch Over Me",
                    Length = TimeSpan.Parse("00:03:18"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Axel Stordahl",
                    AlbumId = 9
                },
                new Song
                {
                    Id = 83,
                    Name = "These Foolish Things",
                    Length = TimeSpan.Parse("00:03:08"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Axel Stordahl",
                    AlbumId = 9
                },
                new Song
                {
                    Id = 84,
                    Name = "Why Shouldnt I?",
                    Length = TimeSpan.Parse("00:02:53"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Axel Stordahl",
                    AlbumId = 9
                },
                new Song
                {
                    Id = 85,
                    Name = "I Dont Know Why",
                    Length = TimeSpan.Parse("00:02:46"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Axel Stordahl",
                    AlbumId = 9
                },
                new Song
                {
                    Id = 86,
                    Name = "Try a Little Tenderness",
                    Length = TimeSpan.Parse("00:03:08"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Axel Stordahl",
                    AlbumId = 9
                },
                new Song
                {
                    Id = 87,
                    Name = "I Dont Stand a Ghost of a Chance with You",
                    Length = TimeSpan.Parse("00:03:11"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Axel Stordahl",
                    AlbumId = 9
                },
                new Song
                {
                    Id = 88,
                    Name = "Paradise",
                    Length = TimeSpan.Parse("00:02:37"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Axel Stordahl",
                    AlbumId = 9
                },
                new Song
                {
                    Id = 89,
                    Name = "Colors",
                    Length = TimeSpan.Parse("00:04:21"),
                    Comment = null,
                    BillBoardRank = 3,
                    BillBoardDate = DateTime.Parse("6/23/2018 12:00:00 AM"),
                    Writer = "Beck Hansen",
                    AlbumId = 10
                },
                new Song
                {
                    Id = 90,
                    Name = "Seventh Heaven",
                    Length = TimeSpan.Parse("00:05:00"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Beck Hansen",
                    AlbumId = 10
                },
                new Song
                {
                    Id = 91,
                    Name = "Im So Free",
                    Length = TimeSpan.Parse("00:04:07"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Beck Hansen",
                    AlbumId = 10
                },
                new Song
                {
                    Id = 92,
                    Name = "Dear Life",
                    Length = TimeSpan.Parse("00:03:44"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Beck Hansen",
                    AlbumId = 10
                },
                new Song
                {
                    Id = 93,
                    Name = "No Distraction",
                    Length = TimeSpan.Parse("00:04:32"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Beck Hansen",
                    AlbumId = 10
                },
                new Song
                {
                    Id = 94,
                    Name = "Dreams",
                    Length = TimeSpan.Parse("00:04:57"),
                    Comment = null,
                    BillBoardRank = 1,
                    BillBoardDate = DateTime.Parse("7/11/2015 12:00:00 AM"),
                    Writer = "Beck Hansen",
                    AlbumId = 10
                },
                new Song
                {
                    Id = 95,
                    Name = "Wow",
                    Length = TimeSpan.Parse("00:03:40"),
                    Comment = null,
                    BillBoardRank = 10,
                    BillBoardDate = DateTime.Parse("8/20/2016 12:00:00 AM"),
                    Writer = "Beck Hansen",
                    AlbumId = 10
                },
                new Song
                {
                    Id = 96,
                    Name = "Up All Night",
                    Length = TimeSpan.Parse("00:03:10"),
                    Comment = null,
                    BillBoardRank = 30,
                    BillBoardDate = DateTime.Parse("3/3/2018 12:00:00 AM"),
                    Writer = "Beck Hansen",
                    AlbumId = 10
                },
                new Song
                {
                    Id = 97,
                    Name = "Square One",
                    Length = TimeSpan.Parse("02:55:00"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Beck Hansen",
                    AlbumId = 10
                },
                new Song
                {
                    Id = 98,
                    Name = "Fix Me",
                    Length = TimeSpan.Parse("00:03:13"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Beck Hansen",
                    AlbumId = 10
                },
                new Song
                {
                    Id = 99,
                    Name = "In Them Old Cottonfields Back Home",
                    Length = TimeSpan.Parse("00:02:33"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Lead Belly",
                    AlbumId = 11
                },
                new Song
                {
                    Id = 100,
                    Name = "Im So Lonesome I Could Cry",
                    Length = TimeSpan.Parse("00:02:38"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Hank Williams",
                    AlbumId = 11
                },
                new Song
                {
                    Id = 101,
                    Name = "Frankies Man Johnny",
                    Length = TimeSpan.Parse("00:02:17"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Johnny Cash",
                    AlbumId = 11
                },
                new Song
                {
                    Id = 102,
                    Name = "In the Jailhouse Now",
                    Length = TimeSpan.Parse("00:02:22"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Jimmie Rodgers",
                    AlbumId = 11
                },
                new Song
                {
                    Id = 103,
                    Name = "My Shoes Keep Walking Back to You",
                    Length = TimeSpan.Parse("00:02:23"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Lee Ross",
                    AlbumId = 11
                },
                new Song
                {
                    Id = 104,
                    Name = "Dont Take Your Guns to Town",
                    Length = TimeSpan.Parse("00:03:04"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Cash",
                    AlbumId = 11
                },
                new Song
                {
                    Id = 105,
                    Name = "Great Speckled Bird",
                    Length = TimeSpan.Parse("00:02:04"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Roy Carter",
                    AlbumId = 11
                },
                new Song
                {
                    Id = 106,
                    Name = "Five Feet High and Rising",
                    Length = TimeSpan.Parse("00:01:49"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Cash ",
                    AlbumId = 11
                },
                new Song
                {
                    Id = 107,
                    Name = "I Forgot More Than Youll Ever Know",
                    Length = TimeSpan.Parse("00:02:29"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Cecil. A Null",
                    AlbumId = 11
                },
                new Song
                {
                    Id = 108,
                    Name = "Loser",
                    Length = TimeSpan.Parse("00:03:55"),
                    Comment = null,
                    BillBoardRank = 1,
                    BillBoardDate = DateTime.Parse("2/5/1994 12:00:00 AM"),
                    Writer = "Hansen",
                    AlbumId = 12
                },
                new Song
                {
                    Id = 109,
                    Name = "Pay No Mind(Snoozer)",
                    Length = TimeSpan.Parse("00:03:15"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Beck",
                    AlbumId = 12
                },
                new Song
                {
                    Id = 110,
                    Name = "F*cking with My Head(Mountain Dew Rock)",
                    Length = TimeSpan.Parse("00:03:41"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Beck",
                    AlbumId = 12
                },
                new Song
                {
                    Id = 111,
                    Name = "Whickeyclone, Hotel City 1997",
                    Length = TimeSpan.Parse("00:03:28"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Beck",
                    AlbumId = 12
                },
                new Song
                {
                    Id = 112,
                    Name = "Soul Sucking Jerk",
                    Length = TimeSpan.Parse("00:03:57"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Hansen",
                    AlbumId = 12
                },
                new Song
                {
                    Id = 113,
                    Name = "Truckdrivin Neighbors Downstairs(Yellow Sweat)",
                    Length = TimeSpan.Parse("00:02:55"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Beck",
                    AlbumId = 12
                },
                new Song
                {
                    Id = 114,
                    Name = "Sweet Sunshine",
                    Length = TimeSpan.Parse("04:14:00"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Hansen",
                    AlbumId = 12
                },
                new Song
                {
                    Id = 115,
                    Name = "Beercan",
                    Length = TimeSpan.Parse("00:04:00"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Hansen",
                    AlbumId = 12
                },
                new Song
                {
                    Id = 116,
                    Name = "Steal My Body Home",
                    Length = TimeSpan.Parse("00:05:34"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Beck",
                    AlbumId = 12
                },
                new Song
                {
                    Id = 117,
                    Name = "Nitemare Hippy Girl",
                    Length = TimeSpan.Parse("00:02:55"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Beck",
                    AlbumId = 12
                },
                new Song
                {
                    Id = 118,
                    Name = "Mutherf*ker",
                    Length = TimeSpan.Parse("00:02:04"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Beck",
                    AlbumId = 12
                },
                new Song
                {
                    Id = 119,
                    Name = "Blackhole",
                    Length = TimeSpan.Parse("00:02:04"),
                    Comment = null,
                    BillBoardRank = null,
                    BillBoardDate = null,
                    Writer = "Beck",
                    AlbumId = 12
                });
        }

    }
}
