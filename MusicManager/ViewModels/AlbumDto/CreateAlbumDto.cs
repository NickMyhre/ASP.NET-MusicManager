using MusicManager.ViewModels.Artist;
using System.ComponentModel.DataAnnotations;

namespace MusicManager.ViewModels.Album
{
    public class CreateAlbumDto : BaseAlbumDto
    {
        public string? Fact { get; set; }
        [Required(ErrorMessage = "You need to select an artist before adding an album.")]
        public List<int>? ArtistIds { get; set; }
        public void SetArtists()
        {
            foreach (var id in this.ArtistIds)
            {
                this.Artists.Add(new ArtistDto() { Id = id });
            }
        }
    }
}
