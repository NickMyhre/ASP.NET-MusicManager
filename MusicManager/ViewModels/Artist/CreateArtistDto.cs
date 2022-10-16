using Microsoft.Build.Framework;
using System.ComponentModel;

namespace MusicManager.ViewModels.Artist
{
    public class CreateArtistDto : BaseArtistDto
    {
        [DisplayName("Stage Name")]
        public string? StageName { get; set; }
        [Required]
        public string? Fact { get; set; }
    }
}
