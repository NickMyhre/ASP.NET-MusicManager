using System.ComponentModel.DataAnnotations;

namespace MusicManager.ViewModels.Song
{
    public class SongDetailsDto : BaseSongDto
    {
        public int Id { get; set; }
        [Required]
        public TimeSpan? Length { get; set; }
        public string? Comment { get; set; }
        public int? BillBoardRank { get; set; }
        [DisplayFormat(DataFormatString = "{0:dddd, MMMM d, yyyy}")]
        public DateTime? BillBoardDate { get; set; }
    }
}
