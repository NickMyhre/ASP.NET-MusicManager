using System.ComponentModel.DataAnnotations;

namespace MusicManager.ViewModels.Song
{
    public class UpdateSongDto : CreateSongDto
    {
        [Required]
        public int Id { get; set; }
    }
}
