using System.ComponentModel.DataAnnotations;

namespace MusicManager.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string? StageName { get; set; }
        [Required]
        public string? BirthName { get; set; }
        [Required]
        public string? Hometown { get; set; }
        [Required]
        public DateTime? BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        public string? Fact { get; set; }
        public virtual ICollection<Album>? Albums { get; set; } = new List<Album>();
        public virtual ICollection<Song>? Songs { get; set; } = new List<Song>();
            
    }
}
