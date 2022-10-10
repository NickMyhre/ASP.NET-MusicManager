using MusicManager.Models;
using MusicManager.ViewModels.Song;
using System.ComponentModel.DataAnnotations;

namespace MusicManager.ViewModels.Artist
{
    public abstract class BaseArtistDto
    {
        [Required]
        public string? BirthName { get; set; }
        [Required]
        public string? Hometown { get; set; }
        [Required]
        public DateTime? BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        public virtual ICollection<Models.Album>? Albums { get; set; }
        public virtual ICollection<SongDto>? Songs { get; set; }
    }
}
