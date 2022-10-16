using Microsoft.AspNetCore.Mvc;
using MusicManager.Models;
using MusicManager.ViewModels.Artist;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MusicManager.ViewModels.Song
{
    public abstract class BaseSongDto
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Writer { get; set; }
        [DisplayName("Album")]
        public int? AlbumId { get; set; }
        public Models.Album? Album { get; set; }
        [DisplayName("Artists")]
        public ICollection<ArtistDto>? Artists { get; set; } = new List<ArtistDto>();
    }
}
