using System.ComponentModel.DataAnnotations;

namespace MusicManager.ViewModels.Song
{
    public class SongDto : BaseSongDto
    {
        public int Id { get; set; }
        public int? BillBoardRank { get; set; }
        [Required]
        public TimeSpan? Length { get; set; }
    }
}
