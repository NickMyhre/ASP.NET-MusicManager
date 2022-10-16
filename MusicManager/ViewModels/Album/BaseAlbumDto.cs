using MusicManager.ViewModels.Artist;
using MusicManager.ViewModels.Song;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MusicManager.ViewModels.Album
{
    public abstract class BaseAlbumDto
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Label { get; set; }
        [Required]
        public string? Genre { get; set; }
        [DisplayName("Release Date")]
        [DisplayFormat(DataFormatString = "{0:dddd, MMMM d, yyyy}")]
        [Required]
        public DateTime? ReleaseDate { get; set; }
        public virtual ICollection<SongDto> Songs { get; set; } = new List<SongDto>();
        [Required]
        [DisplayName("Artists")]
        public virtual ICollection<ArtistDto>? Artists { get; set; } = new List<ArtistDto>();
    }
}
