namespace MusicManager.ViewModels.Artist
{
    public class UpdateArtistDto : BaseArtistDto
    {
        public int Id { get; set; }
        public string? StageName { get; set; }
        public string? Fact { get; set; }
    }
}
