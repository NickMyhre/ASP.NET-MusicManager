using Microsoft.EntityFrameworkCore;
using MusicManager.Contracts;
using MusicManager.Models;
using MusicManager.ViewModels.Artist;

namespace MusicManager.Repositories
{
    public class ArtistsRepository : GenericRepository<Artist>, IArtistsRepository
    {
        private readonly MusicDbContext _context;

        public ArtistsRepository(MusicDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Artist> AddAsync(Artist entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<Artist>> GetAllAsync()
        {
            return await _context.Artists.Include(s => s.Songs).ToListAsync();
        }

        public async Task<Artist> GetDetails(int id)
        {
            return await _context.Artists.Include(m => m.Songs).Include(m => m.Albums)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task UpdateAsync(Artist entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
