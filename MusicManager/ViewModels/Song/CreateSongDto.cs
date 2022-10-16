using MusicManager.ViewModels.Artist;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MusicManager.ViewModels.Song
{
    public class CreateSongDto : BaseSongDto
    {
        [Required]
        public TimeSpan? Length { get; set; }
        public string? Comment { get; set; }
        [DisplayName("Billboard Rank")]
        public int? BillBoardRank { get; set; }
        [DisplayName("Billboard Date")]
        public DateTime? BillBoardDate { get; set; }
        [Required(ErrorMessage = "You need to select an artist before adding a song.")]
        [DisplayName("Artists")]
        public List<int>? ArtistIds { get; set; }
        public void SetArtists()
        {
            foreach (var id in this.ArtistIds)
            {
                this.Artists.Add( new ArtistDto() { Id = id });
            }
        }
    }
}
