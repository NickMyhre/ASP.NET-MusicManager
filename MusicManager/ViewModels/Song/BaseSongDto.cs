using MusicManager.Models;
using MusicManager.ViewModels.Artist;
using System.ComponentModel.DataAnnotations;

namespace MusicManager.ViewModels.Song
{
    public abstract class BaseSongDto
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Writer { get; set; }
        public int? AlbumId { get; set; }
        public Album? Album { get; set; }
        [Required]
        public ICollection<ArtistDto>? Artists { get; set; }
    }
}
