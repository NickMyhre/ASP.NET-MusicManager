using Microsoft.AspNetCore.Mvc.Rendering;
using MusicManager.Contracts;
using MusicManager.Enumerations;
using MusicManager.Models;

namespace MusicManager.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MusicDbContext _context;

        public GenericRepository(MusicDbContext context)
        {
            this._context = context;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);

            if (entity == null)
            {
                
            }

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<T> GetAsync(int? id)
        {
            if (id == null)
            {
                return null;
            }

            return await _context.Set<T>().FindAsync(id);
        }

        public SelectList? GetSelectListAsync(SelectType type, List<int>? values, int? value)
        {
            const string Id = "Id";
            const string BirthName = "BirthName";
            const string Title = "Title";
            const string Name = "Name";

            //intialize as blank list if null
            values = values ?? new List<int>();
            value = value ?? 0;

            switch (type)
            {
                case SelectType.Artist:
                    return values.Any() ? new SelectList(_context.Artists, Id, BirthName, values) : new SelectList(_context.Artists, Id, BirthName);
                case SelectType.Album:
                    return value != 0 ? new SelectList(_context.Albums, Id, Title, values) : new SelectList(_context.Albums, Id, Title);
                case SelectType.Song:
                    return values.Any() ? new SelectList(_context.Songs, Id, Name, values) : new SelectList(_context.Songs, Id, Name);
                default:
                    return null;
            }
        }

        public bool HasEntries(SelectType type)
        {
            switch (type)
            {
                case SelectType.Artist:
                    return _context.Artists.Any();
                case SelectType.Album:
                    return _context.Albums.Any();
                case SelectType.Song:
                    return _context.Songs.Any();
                default:
                    return false;
            }
        }
    }
}
