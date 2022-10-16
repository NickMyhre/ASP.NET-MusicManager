using System.ComponentModel;

namespace MusicManager.ViewModels.Artist
{
    public class UpdateArtistDto : BaseArtistDto
    {
        public int Id { get; set; }
        [DisplayName("Stage Name")]
        public string? StageName { get; set; }
        public string? Fact { get; set; }
    }
}
