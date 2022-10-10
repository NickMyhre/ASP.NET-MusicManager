using MusicManager.Models;
using MusicManager.ViewModels.Artist;

namespace MusicManager.Contracts
{
    public interface IArtistsRepository : IGenericRepository<Artist>
    {
        Task<Artist> GetDetails(int id);
        Task<List<Artist>> GetAllAsync();
        Task UpdateAsync(Artist entity);
        Task<Artist> AddAsync(Artist entity);
    }
}
