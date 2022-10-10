using MusicManager.ViewModels.Artist;
using System.ComponentModel.DataAnnotations;

namespace MusicManager.ViewModels.Song
{
    public class CreateSongDto : BaseSongDto
    {
        [Required]
        public TimeSpan? Length { get; set; }
        public string? Comment { get; set; }
        public int? BillBoardRank { get; set; }
        public DateTime? BillBoardDate { get; set; }
        [Required(ErrorMessage = "You need to select an artist before adding a song.")]
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
