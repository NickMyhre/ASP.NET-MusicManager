using System.ComponentModel.DataAnnotations;

namespace MusicManager.ViewModels.Song
{
    public class CreateSongDto
    {
        [Required]
        public TimeSpan? Length { get; set; }
        public string? Comment { get; set; }
        public int? BillBoardRank { get; set; }
        public DateTime? BillBoardDate { get; set; }
    }
}
