using Microsoft.EntityFrameworkCore;
using MusicManager.Contracts;
using MusicManager.Models;
using MusicManager.ViewModels.Song;
using NuGet.Packaging;

namespace MusicManager.Repositories
{
    public class SongsRepository : GenericRepository<Song>, ISongsRepository
    {
        private readonly MusicDbContext _context;

        public SongsRepository(MusicDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Song> AddAsync(Song entity)
        {
            _context.AttachRange(entity.Artists);
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<Song>> GetAllAsync()
        {
            return await _context.Songs.Include(s => s.Album).ToListAsync();
        }

        public async Task<Song> GetDetails(int id)
        {
            return await _context.Songs.Include(s => s.Album).Include(m => m.Artists).FirstOrDefaultAsync(m => m.Id == id);

        }

        public async Task UpdateAsync(UpdateSongDto entity)
        {
            var song = _context.Songs.Where(x => x.Id == entity.Id).Include(m => m.Artists).FirstOrDefault();
            var existingArtists = song.Artists.Select(x => x.Id).ToList();
            var removeArtists = existingArtists.Except(entity.ArtistIds).ToList();
            var addArtists = entity.ArtistIds.Except(existingArtists).ToList();


            foreach (var artist in removeArtists)
            {
                song.Artists.Remove(_context.Artists.Single(x => x.Id == artist));
            }

            var artistsToAdd = _context.Artists.Where(x => addArtists.Contains(x.Id)).ToList();


            song.Artists.AddRange(artistsToAdd);

            song.Name = entity.Name;
            song.Length = entity.Length;
            song.Writer = entity.Writer;
            song.BillBoardRank = entity.BillBoardRank;
            song.BillBoardDate = entity.BillBoardDate;
            song.AlbumId = entity.AlbumId;

            _context.Songs.Update(song);
            await _context.SaveChangesAsync();
        }
    }
}
