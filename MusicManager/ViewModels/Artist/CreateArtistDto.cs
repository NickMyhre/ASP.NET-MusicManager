using Microsoft.Build.Framework;

namespace MusicManager.ViewModels.Artist
{
    public class CreateArtistDto : BaseArtistDto
    {
        public string? StageName { get; set; }
        [Required]
        public string? Fact { get; set; }
    }
}
