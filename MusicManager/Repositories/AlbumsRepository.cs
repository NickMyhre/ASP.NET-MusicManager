using Microsoft.CodeAnalysis.Differencing;
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
            var album = await _context.Albums.Include(m => m.Artists).Include(m => m.Songs)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (album == null)
            {
                return new Album();
            }
            return album;
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
            var album = await _context.Albums.Include(m => m.Artists).Include(m => m.Songs).ThenInclude(x => x.Artists)
                .FirstOrDefaultAsync(m => m.Id == id);

            _context.RemoveRange(album.Songs);
            _context.Remove(album);

            foreach (var artist in album.Artists)
            {
                //Get song count of artists songs in album
                int artistSongsInAlbum = album.Artists.Where(x => x.Id == artist.Id).Select(x => x.Songs.Where(a => a.AlbumId == album.Id)).Count();

                //delete artist if the artists total number of songs is equal to the number of the songs from album
                if (artistSongsInAlbum == artist.Songs.Count())
                {
                    _context.Artists.Remove(artist);
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
