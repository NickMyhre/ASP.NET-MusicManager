using MusicManager.Models;
using MusicManager.ViewModels.Album;
using MusicManager.ViewModels.Song;

namespace MusicManager.Contracts
{
    public interface IAlbumsRepository : IGenericRepository<Album>
    {
        Task<Album> GetDetails(int id);
        Task<List<Album>> GetAllAsync();
        Task UpdateAsync(UpdateAlbumDto entity);
        Task<Album> AddAsync(Album entity);
    }
}
