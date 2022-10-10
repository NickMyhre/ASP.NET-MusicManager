using MusicManager.Models;
using MusicManager.ViewModels.Song;

namespace MusicManager.Contracts
{
    public interface ISongsRepository : IGenericRepository<Song>
    {
        Task<Song> GetDetails(int id);
        Task<List<Song>> GetAllAsync();
        Task UpdateAsync(UpdateSongDto entity);
        Task<Song> AddAsync(Song entity);
    }
}
