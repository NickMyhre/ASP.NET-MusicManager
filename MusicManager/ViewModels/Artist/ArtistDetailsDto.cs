namespace MusicManager.ViewModels.Artist
{
    public class ArtistDetailsDto : ArtistDto
    {
        public int Id { get; set; }
        public string? StageName { get; set; }
        public string? Fact { get; set; }
    }
}
