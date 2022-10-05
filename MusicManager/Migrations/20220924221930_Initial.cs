using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicManager.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fact = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hometown = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeathDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fact = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<TimeSpan>(type: "time", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillBoardRank = table.Column<int>(type: "int", nullable: true),
                    BillBoardDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Writer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ArtistAlbums",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistAlbums", x => new { x.ArtistId, x.AlbumId });
                    table.ForeignKey(
                        name: "FK_ArtistAlbums_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistAlbums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistSongs",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSongs", x => new { x.ArtistId, x.SongId });
                    table.ForeignKey(
                        name: "FK_ArtistSongs_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistSongs_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Fact", "Genre", "Label", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "positive album", "Alternative", "UME", new DateTime(2015, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Higher Truth" },
                    { 2, "released after death", "Alternative", "UME", new DateTime(2020, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "No One Sings Like You Anymore, Vol. 1" },
                    { 3, "Second album by Mr. Bruce", "Rock and Roll", "Columbia", new DateTime(1973, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wild, the Innocent, & the E Street Shuffle" },
                    { 4, "Was supposed to have duets with Michael Jackson", "Synth-Pop", "Columbia", new DateTime(1985, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mr. Bad Guy" },
                    { 5, "First concept album", "Country", "Columbia", new DateTime(1960, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ride This Train" },
                    { 6, "About the american working man", "Country", "Legacy", new DateTime(1963, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blood, Sweat, and Tears" },
                    { 7, "Nasty cover photo", "Alternative", "DreamWorks", new DateTime(2000, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Infest" },
                    { 8, "Third album from the dude", "Alternative", "Fueled by Ramen", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death of an Optimist" },
                    { 9, null, "Traditional Pop", "Columbia", new DateTime(1946, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Voice of Frank Sinatra" },
                    { 10, "The thirteenth Beck album", "Pop", "Capitol", new DateTime(2017, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colors" },
                    { 11, "Release date month and day is a little ambiguous", "Country", "Columbia", new DateTime(1974, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Five Feet High and Rising" },
                    { 12, "Like a satanic K-tel record thats been found in a trash dumpster", "Alternative", "DGC", new DateTime(1994, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mellow Gold" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "BirthDate", "BirthName", "DeathDate", "Fact", "Hometown", "StageName" },
                values: new object[,]
                {
                    { 1, new DateTime(1964, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chris Cornell", new DateTime(2017, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lead Singer in Soundgarden", "Seattle", null },
                    { 2, new DateTime(1949, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruce Springsteen", null, "Dedicated an album to 9/11 victims", "New Jersey", null },
                    { 3, new DateTime(1946, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Farrokh Bulsara", new DateTime(1991, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Born in Zanzibar", "Sultanate", "Freddie Mercury" },
                    { 4, new DateTime(1932, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnny Cash", new DateTime(2003, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Covered a Nine-Inch Nails Song", "Kingsland", "The Man in Black" },
                    { 5, new DateTime(1976, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacoby Shaddix", null, "Host of Scarred", "Vacaville", "Papa Roach" },
                    { 6, new DateTime(1993, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordan Benjamin", null, "Canadian dude", "Toronto", "Grandson" },
                    { 7, new DateTime(1915, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank Sinatra", new DateTime(1998, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lived in a rat-infested shed", "Hoboken", null },
                    { 8, new DateTime(1970, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bek Cambell", null, "Host of Scarred", "Los Angelas", "Beck" }
                });

            migrationBuilder.InsertData(
                table: "ArtistAlbums",
                columns: new[] { "AlbumId", "ArtistId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 3 },
                    { 5, 4 },
                    { 6, 4 },
                    { 11, 4 },
                    { 7, 5 },
                    { 8, 6 },
                    { 9, 7 },
                    { 10, 8 },
                    { 12, 8 }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "BillBoardDate", "BillBoardRank", "Comment", "Length", "Name", "Writer" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2015, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Good Song", new TimeSpan(0, 0, 3, 54, 0), "Nearly Forgot My Broken Heart", "Chris Cornell" },
                    { 2, 1, null, null, "Havent Heard", new TimeSpan(0, 0, 3, 54, 0), "Dead Wishes", "Chris Cornell" },
                    { 3, 1, null, null, "Havent Heard", new TimeSpan(0, 0, 4, 32, 0), "Worried Moon", "Chris Cornell" },
                    { 4, 1, null, null, "Havent Heard", new TimeSpan(0, 0, 3, 51, 0), "Before We Disappear", "" },
                    { 5, 1, null, null, "Havent Heard", new TimeSpan(0, 0, 4, 41, 0), "Through the Window", "Chris Cornell" },
                    { 6, 1, null, null, "Havent Heard", new TimeSpan(0, 0, 3, 38, 0), "Josephine", "Chris Cornell" },
                    { 7, 1, null, null, "Havent Heard", new TimeSpan(0, 0, 3, 42, 0), "Murderer of Blue Skies", "Chris Cornell" },
                    { 8, 1, null, null, "Havent Heard", new TimeSpan(0, 0, 5, 6, 0), "Higher Truth", "Chris Cornell" },
                    { 9, 1, null, null, "Havent Heard", new TimeSpan(0, 0, 3, 42, 0), "Let Your Eyes Wander", "Chris Cornell" },
                    { 10, 1, null, null, "Havent Heard", new TimeSpan(0, 0, 3, 29, 0), "Only These Words", "Chris Cornell" },
                    { 11, 1, null, null, "Havent Heard", new TimeSpan(0, 0, 3, 28, 0), "Circling", "Chris Cornell" },
                    { 12, 1, null, null, "Havent Heard", new TimeSpan(0, 0, 4, 19, 0), "Our Time in the Universe", "Chris Cornell" },
                    { 13, 2, null, null, "Havent Heard", new TimeSpan(0, 0, 3, 22, 0), "Get It While You Can", "Jerry Ragovoy" },
                    { 14, 2, null, null, "Havent Heard", new TimeSpan(0, 0, 3, 35, 0), "Jump into the Fire", "Harry Nilsson" },
                    { 15, 2, null, null, "Havent Heard", new TimeSpan(0, 0, 3, 49, 0), "Sad Sad City", "Aaron Behrens" },
                    { 16, 2, new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Havent Heard", new TimeSpan(0, 0, 4, 13, 0), "Patience", "Guns N Roses" },
                    { 17, 2, null, null, "Havent Heard", new TimeSpan(0, 0, 4, 12, 0), "Nothing Compares 2 U", "Prince" },
                    { 18, 2, null, null, "Havent Heard", new TimeSpan(0, 0, 3, 14, 0), "Watching the Wheels", "John Lennon" },
                    { 19, 2, null, null, "Havent Heard", new TimeSpan(0, 0, 3, 4, 0), "You Dont Know Nothing About Love", "Jerry Ragovoy" },
                    { 20, 2, null, null, "Havent Heard", new TimeSpan(0, 0, 3, 23, 0), "Showdown", "Jeff Lynne" },
                    { 21, 2, null, null, "Havent Heard", new TimeSpan(0, 0, 3, 14, 0), "To Be Treated Rite", "Terry Reid" },
                    { 22, 2, null, null, "Havent Heard", new TimeSpan(0, 0, 4, 15, 0), "Stay with Me Baby", "Jerry Ragovoy" },
                    { 23, 3, null, null, null, new TimeSpan(0, 0, 4, 31, 0), "The E Street Shuffle", "Bruce Springsteen" },
                    { 24, 3, null, null, null, new TimeSpan(0, 0, 5, 36, 0), "4th of July, Asbury Park(Sandy)", "Bruce Springsteen" },
                    { 25, 3, null, null, null, new TimeSpan(0, 0, 7, 9, 0), "Kittys Back", "Bruce Springsteen" },
                    { 26, 3, null, null, null, new TimeSpan(0, 0, 4, 47, 0), "Wild Billys Circus Story", "Bruce Springsteen" },
                    { 27, 3, null, null, null, new TimeSpan(0, 0, 7, 45, 0), "Incident on 57th Street", "Bruce Springsteen" },
                    { 28, 3, null, null, null, new TimeSpan(0, 0, 7, 4, 0), "Rosalita (Come Out Tonight)", "Bruce Springsteen" },
                    { 29, 3, null, null, null, new TimeSpan(0, 0, 9, 55, 0), "New York City Seranade", "Bruce Springsteen" },
                    { 30, 4, null, null, null, new TimeSpan(0, 0, 3, 42, 0), "Lets Turn It On", "Freddie Mercury" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "BillBoardDate", "BillBoardRank", "Comment", "Length", "Name", "Writer" },
                values: new object[,]
                {
                    { 31, 4, null, null, null, new TimeSpan(0, 0, 4, 5, 0), "Made in Heaven", "Freddie Mercury" },
                    { 32, 4, null, null, null, new TimeSpan(0, 0, 3, 38, 0), "I Was Born to Love You", "Freddie Mercury" },
                    { 33, 4, null, null, null, new TimeSpan(0, 0, 3, 29, 0), "Foolin Around", "Freddie Mercury" },
                    { 34, 4, null, null, null, new TimeSpan(0, 0, 3, 32, 0), "Your Kind of Lover", "Freddie Mercury" },
                    { 35, 4, new DateTime(1985, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 159, null, new TimeSpan(0, 0, 4, 9, 0), "Mr. Bad Guy", "Freddie Mercury" },
                    { 36, 4, null, null, null, new TimeSpan(0, 0, 4, 8, 0), "Man Made Paradise", "Freddie Mercury" },
                    { 37, 4, null, null, null, new TimeSpan(0, 0, 3, 0, 0), "There Must Be More to Life Than This", "Freddie Mercury" },
                    { 38, 4, null, null, null, new TimeSpan(0, 0, 3, 42, 0), "My Love is Dangerous", "Freddie Mercury" },
                    { 39, 4, null, null, null, new TimeSpan(0, 0, 3, 46, 0), "Love Me Like Theres No Tomorrow", "Freddie Mercury" },
                    { 40, 4, null, null, null, new TimeSpan(0, 0, 3, 42, 0), "Living on My Own", "Freddie Mercury" },
                    { 41, 5, null, null, null, new TimeSpan(0, 0, 4, 58, 0), "Loading Coal", "Merle Travis" },
                    { 42, 5, null, null, null, new TimeSpan(0, 0, 4, 12, 0), "Slow Rider", "Johnny Cash" },
                    { 43, 5, null, null, null, new TimeSpan(0, 0, 3, 2, 0), "Lumberjack", "Leon Payne" },
                    { 44, 5, null, null, null, new TimeSpan(0, 0, 4, 47, 0), "Dorraine of Ponchartrain", "Cash" },
                    { 45, 5, null, null, null, new TimeSpan(0, 0, 4, 26, 0), "Going to Memphis", "Hollie Dew" },
                    { 46, 5, null, null, null, new TimeSpan(0, 0, 2, 55, 0), "When Papa Played the Dobro", "Cash" },
                    { 47, 5, null, null, null, new TimeSpan(0, 0, 3, 50, 0), "Boss Jack", "Tex Ritter" },
                    { 48, 5, null, null, null, new TimeSpan(0, 0, 4, 10, 0), "Old Doc Brown", "Red Foley" },
                    { 49, 6, null, null, null, new TimeSpan(0, 0, 9, 3, 0), "The Legend of John Henrys Hammer", "Johnny Cash" },
                    { 50, 6, null, null, null, new TimeSpan(0, 0, 3, 3, 0), "Tell Him Im Gone", "Cash" },
                    { 51, 6, null, null, null, new TimeSpan(0, 0, 2, 35, 0), "Another Man Done Gone", "Vera Hall" },
                    { 52, 6, new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, null, new TimeSpan(0, 0, 2, 17, 0), "Busted", "Harlan Howard" },
                    { 53, 6, null, null, null, new TimeSpan(0, 0, 3, 2, 0), "Casey Jones", "Cash" },
                    { 54, 6, null, null, null, new TimeSpan(0, 0, 3, 15, 0), "Nine Pound Hammer", "Merle Travis" },
                    { 55, 6, null, null, null, new TimeSpan(0, 0, 2, 40, 0), "Chain Gang", "Howard" },
                    { 56, 6, null, null, null, new TimeSpan(0, 0, 2, 6, 0), "Waiting for a Train", "Jimmie Rogers" },
                    { 57, 6, null, null, null, new TimeSpan(0, 0, 2, 11, 0), "Roughneck", "Sheb Wooley" },
                    { 58, 7, null, null, null, new TimeSpan(0, 0, 4, 9, 0), "Infest", "Papa Roach" },
                    { 59, 7, new DateTime(2000, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new TimeSpan(0, 0, 3, 19, 0), "Last Resort", "Papa Roach" },
                    { 60, 7, null, null, null, new TimeSpan(0, 0, 3, 41, 0), "Broken Home", "Papa Roach" },
                    { 61, 7, null, null, null, new TimeSpan(0, 0, 3, 6, 0), "Dead Cell", "Papa Roach" },
                    { 62, 7, null, null, null, new TimeSpan(0, 0, 3, 54, 0), "Between Angels and Insects", "Papa Roach" },
                    { 63, 7, null, null, null, new TimeSpan(0, 0, 3, 34, 0), "Blood Brothers", "Papa Roach" },
                    { 64, 7, null, null, null, new TimeSpan(0, 0, 3, 42, 0), "Revenge", "Papa Roach" },
                    { 65, 7, null, null, null, new TimeSpan(0, 0, 3, 29, 0), "Snakes", "Papa Roach" },
                    { 66, 7, null, null, null, new TimeSpan(0, 0, 3, 35, 0), "Never Enough", "Papa Roach" },
                    { 67, 7, null, null, null, new TimeSpan(0, 0, 3, 47, 0), "Binge", "Papa Roach" },
                    { 68, 7, null, null, null, new TimeSpan(0, 0, 9, 36, 0), "Thrown Away", "Papa Roach" },
                    { 69, 8, null, null, null, new TimeSpan(0, 0, 2, 31, 0), "Death of an Optimist // Intro", "Grandson" },
                    { 70, 8, null, null, null, new TimeSpan(0, 0, 3, 18, 0), "In Over My Head", "Grandson" },
                    { 71, 8, null, null, null, new TimeSpan(0, 0, 3, 36, 0), "Identity", "Grandson" },
                    { 72, 8, null, null, null, new TimeSpan(0, 0, 3, 25, 0), "Left Behind", "Grandson" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "BillBoardDate", "BillBoardRank", "Comment", "Length", "Name", "Writer" },
                values: new object[,]
                {
                    { 73, 8, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, null, new TimeSpan(0, 0, 3, 28, 0), "Dirty", "Grandson" },
                    { 74, 8, null, null, null, new TimeSpan(0, 0, 2, 22, 0), "The Ballad of G and X // Interlude", "Grandson" },
                    { 75, 8, null, null, null, new TimeSpan(0, 0, 2, 49, 0), "We Did It!!!", "Grandson" },
                    { 76, 8, null, null, null, new TimeSpan(0, 0, 3, 22, 0), "WWIII", "Grandson" },
                    { 77, 8, null, null, null, new TimeSpan(0, 0, 3, 12, 0), "Riptide", "Grandson" },
                    { 78, 8, null, null, null, new TimeSpan(0, 0, 3, 17, 0), "Pain Shopping", "Grandson" },
                    { 79, 8, null, null, null, new TimeSpan(0, 0, 3, 9, 0), "Drop Dead", "Grandson" },
                    { 80, 8, null, null, null, new TimeSpan(0, 0, 3, 31, 0), "Welcome to Paradise // Outro", "Grandson" },
                    { 81, 9, null, null, null, new TimeSpan(0, 0, 3, 0, 0), "You Go to My Head", "Axel Stordahl" },
                    { 82, 9, null, null, null, new TimeSpan(0, 0, 3, 18, 0), "Someone to Watch Over Me", "Axel Stordahl" },
                    { 83, 9, null, null, null, new TimeSpan(0, 0, 3, 8, 0), "These Foolish Things", "Axel Stordahl" },
                    { 84, 9, null, null, null, new TimeSpan(0, 0, 2, 53, 0), "Why Shouldnt I?", "Axel Stordahl" },
                    { 85, 9, null, null, null, new TimeSpan(0, 0, 2, 46, 0), "I Dont Know Why", "Axel Stordahl" },
                    { 86, 9, null, null, null, new TimeSpan(0, 0, 3, 8, 0), "Try a Little Tenderness", "Axel Stordahl" },
                    { 87, 9, null, null, null, new TimeSpan(0, 0, 3, 11, 0), "I Dont Stand a Ghost of a Chance with You", "Axel Stordahl" },
                    { 88, 9, null, null, null, new TimeSpan(0, 0, 2, 37, 0), "Paradise", "Axel Stordahl" },
                    { 89, 10, new DateTime(2018, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, new TimeSpan(0, 0, 4, 21, 0), "Colors", "Beck Hansen" },
                    { 90, 10, null, null, null, new TimeSpan(0, 0, 5, 0, 0), "Seventh Heaven", "Beck Hansen" },
                    { 91, 10, null, null, null, new TimeSpan(0, 0, 4, 7, 0), "Im So Free", "Beck Hansen" },
                    { 92, 10, null, null, null, new TimeSpan(0, 0, 3, 44, 0), "Dear Life", "Beck Hansen" },
                    { 93, 10, null, null, null, new TimeSpan(0, 0, 4, 32, 0), "No Distraction", "Beck Hansen" },
                    { 94, 10, new DateTime(2015, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new TimeSpan(0, 0, 4, 57, 0), "Dreams", "Beck Hansen" },
                    { 95, 10, new DateTime(2016, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, null, new TimeSpan(0, 0, 3, 40, 0), "Wow", "Beck Hansen" },
                    { 96, 10, new DateTime(2018, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, null, new TimeSpan(0, 0, 3, 10, 0), "Up All Night", "Beck Hansen" },
                    { 97, 10, null, null, null, new TimeSpan(0, 2, 55, 0, 0), "Square One", "Beck Hansen" },
                    { 98, 10, null, null, null, new TimeSpan(0, 0, 3, 13, 0), "Fix Me", "Beck Hansen" },
                    { 99, 11, null, null, null, new TimeSpan(0, 0, 2, 33, 0), "In Them Old Cottonfields Back Home", "Lead Belly" },
                    { 100, 11, null, null, null, new TimeSpan(0, 0, 2, 38, 0), "Im So Lonesome I Could Cry", "Hank Williams" },
                    { 101, 11, null, null, null, new TimeSpan(0, 0, 2, 17, 0), "Frankies Man Johnny", "Johnny Cash" },
                    { 102, 11, null, null, null, new TimeSpan(0, 0, 2, 22, 0), "In the Jailhouse Now", "Jimmie Rodgers" },
                    { 103, 11, null, null, null, new TimeSpan(0, 0, 2, 23, 0), "My Shoes Keep Walking Back to You", "Lee Ross" },
                    { 104, 11, null, null, null, new TimeSpan(0, 0, 3, 4, 0), "Dont Take Your Guns to Town", "Cash" },
                    { 105, 11, null, null, null, new TimeSpan(0, 0, 2, 4, 0), "Great Speckled Bird", "Roy Carter" },
                    { 106, 11, null, null, null, new TimeSpan(0, 0, 1, 49, 0), "Five Feet High and Rising", "Cash " },
                    { 107, 11, null, null, null, new TimeSpan(0, 0, 2, 29, 0), "I Forgot More Than Youll Ever Know", "Cecil. A Null" },
                    { 108, 12, new DateTime(1994, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new TimeSpan(0, 0, 3, 55, 0), "Loser", "Hansen" },
                    { 109, 12, null, null, null, new TimeSpan(0, 0, 3, 15, 0), "Pay No Mind(Snoozer)", "Beck" },
                    { 110, 12, null, null, null, new TimeSpan(0, 0, 3, 41, 0), "F*cking with My Head(Mountain Dew Rock)", "Beck" },
                    { 111, 12, null, null, null, new TimeSpan(0, 0, 3, 28, 0), "Whickeyclone, Hotel City 1997", "Beck" },
                    { 112, 12, null, null, null, new TimeSpan(0, 0, 3, 57, 0), "Soul Sucking Jerk", "Hansen" },
                    { 113, 12, null, null, null, new TimeSpan(0, 0, 2, 55, 0), "Truckdrivin Neighbors Downstairs(Yellow Sweat)", "Beck" },
                    { 114, 12, null, null, null, new TimeSpan(0, 4, 14, 0, 0), "Sweet Sunshine", "Hansen" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "BillBoardDate", "BillBoardRank", "Comment", "Length", "Name", "Writer" },
                values: new object[,]
                {
                    { 115, 12, null, null, null, new TimeSpan(0, 0, 4, 0, 0), "Beercan", "Hansen" },
                    { 116, 12, null, null, null, new TimeSpan(0, 0, 5, 34, 0), "Steal My Body Home", "Beck" },
                    { 117, 12, null, null, null, new TimeSpan(0, 0, 2, 55, 0), "Nitemare Hippy Girl", "Beck" },
                    { 118, 12, null, null, null, new TimeSpan(0, 0, 2, 4, 0), "Mutherf*ker", "Beck" },
                    { 119, 12, null, null, null, new TimeSpan(0, 0, 2, 4, 0), "Blackhole", "Beck" }
                });

            migrationBuilder.InsertData(
                table: "ArtistSongs",
                columns: new[] { "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 1, 21 },
                    { 1, 22 },
                    { 2, 23 },
                    { 2, 24 },
                    { 2, 25 },
                    { 2, 26 },
                    { 2, 27 },
                    { 2, 28 },
                    { 2, 29 },
                    { 3, 30 },
                    { 3, 31 },
                    { 3, 32 },
                    { 3, 33 },
                    { 3, 34 },
                    { 3, 35 },
                    { 3, 36 },
                    { 3, 37 },
                    { 3, 38 },
                    { 3, 39 },
                    { 3, 40 },
                    { 4, 41 },
                    { 4, 42 }
                });

            migrationBuilder.InsertData(
                table: "ArtistSongs",
                columns: new[] { "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 4, 43 },
                    { 4, 44 },
                    { 4, 45 },
                    { 4, 46 },
                    { 4, 47 },
                    { 4, 48 },
                    { 4, 49 },
                    { 4, 50 },
                    { 4, 51 },
                    { 4, 52 },
                    { 4, 53 },
                    { 4, 54 },
                    { 4, 55 },
                    { 4, 56 },
                    { 4, 57 },
                    { 4, 99 },
                    { 4, 100 },
                    { 4, 101 },
                    { 4, 102 },
                    { 4, 103 },
                    { 4, 104 },
                    { 4, 105 },
                    { 4, 106 },
                    { 4, 107 },
                    { 5, 58 },
                    { 5, 59 },
                    { 5, 60 },
                    { 5, 61 },
                    { 5, 62 },
                    { 5, 63 },
                    { 5, 64 },
                    { 5, 65 },
                    { 5, 66 },
                    { 5, 67 },
                    { 5, 68 },
                    { 6, 69 },
                    { 6, 70 },
                    { 6, 71 },
                    { 6, 72 },
                    { 6, 73 },
                    { 6, 74 },
                    { 6, 75 }
                });

            migrationBuilder.InsertData(
                table: "ArtistSongs",
                columns: new[] { "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 6, 76 },
                    { 6, 77 },
                    { 6, 78 },
                    { 6, 79 },
                    { 6, 80 },
                    { 7, 81 },
                    { 7, 82 },
                    { 7, 83 },
                    { 7, 84 },
                    { 7, 85 },
                    { 7, 86 },
                    { 7, 87 },
                    { 7, 88 },
                    { 8, 89 },
                    { 8, 90 },
                    { 8, 91 },
                    { 8, 92 },
                    { 8, 93 },
                    { 8, 94 },
                    { 8, 95 },
                    { 8, 96 },
                    { 8, 97 },
                    { 8, 98 },
                    { 8, 108 },
                    { 8, 109 },
                    { 8, 110 },
                    { 8, 111 },
                    { 8, 112 },
                    { 8, 113 },
                    { 8, 114 },
                    { 8, 115 },
                    { 8, 116 },
                    { 8, 117 },
                    { 8, 118 },
                    { 8, 119 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistAlbums_AlbumId",
                table: "ArtistAlbums",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSongs_SongId",
                table: "ArtistSongs",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistAlbums");

            migrationBuilder.DropTable(
                name: "ArtistSongs");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
