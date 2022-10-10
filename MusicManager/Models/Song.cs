using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicManager.Models
{
    public class Song
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public TimeSpan? Length { get; set; }
        public string? Comment { get; set; }
        public int? BillBoardRank { get; set; }
        public DateTime? BillBoardDate { get; set; }
        [Required]
        public string? Writer { get; set; }
        public int? AlbumId { get; set; }
        public Album? Album { get; set; }
        [Required]
        public virtual ICollection<Artist> Artists { get; set; } = new List<Artist>();
    }
}
