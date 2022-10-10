using Microsoft.EntityFrameworkCore;
using MusicManager.Contracts;
using MusicManager.Models;
using MusicManager.ViewModels.Album;
using NuGet.Packaging;

namespace MusicManager.Repositories
{
    public class AlbumsRepository : GenericRepository<Album>, IAlbumsRepository
    {
        private readonly MusicDbContext _context;

        public AlbumsRepository(MusicDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Album> AddAsync(Album entity)
        {
            _context.AttachRange(entity.Artists);
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<Album>> GetAllAsync()
        {
            return await _context.Albums.Include(m => m.Artists).ToListAsync();
        }

        public async Task<Album> GetDetails(int id)
        {
            return await _context.Albums.Include(m => m.Artists).Include(m=>m.Songs)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task UpdateAsync(UpdateAlbumDto entity)
        {
            var album = _context.Albums.Where(x => x.Id == entity.Id).Include(m => m.Artists).FirstOrDefault();
            var existingArtists = album.Artists.Select(x => x.Id).ToList();
            var removeArtists = existingArtists.Except(entity.ArtistIds).ToList();
            var addArtists = entity.ArtistIds.Except(existingArtists).ToList();


            foreach (var artist in removeArtists)
            {
                album.Artists.Remove(_context.Artists.Single(x => x.Id == artist));
            }

            var artistsToAdd = _context.Artists.Where(x => addArtists.Contains(x.Id)).ToList();


            album.Artists.AddRange(artistsToAdd);

            album.Title = entity.Title;
            album.Label = entity.Label;
            album.Genre = entity.Genre;
            album.ReleaseDate = entity.ReleaseDate;
            album.Fact = entity.Fact;

            _context.Albums.Update(album);
            await _context.SaveChangesAsync();
        }

        new public async Task DeleteAsync(int id)
        {
            var entity = await GetDetails(id);

            _context.RemoveRange(entity.Songs);
            _context.Remove(entity);

            foreach (var artist in entity.Artists)
            {
                int albumSongs = _context.Albums.Where(x => x.Id == artist.Id).Include(x=>x.Songs).Select(x => x.Songs).Count();
                if (albumSongs == entity.Songs.Count())
                {
                    _context.Artists.Remove(artist);
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
