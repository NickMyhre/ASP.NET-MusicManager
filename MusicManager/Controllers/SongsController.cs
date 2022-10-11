using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicManager.Models;
using MusicManager.ViewModels.Song;
using MusicManager.Contracts;
using MusicManager.Enumerations;
using MusicManager.Enumerations.Sorting;
using MusicManager.Utility;

namespace MusicManager.Controllers
{
    public class SongsController : Controller
    {
        private readonly ISongsRepository _songsRepository;
        private readonly IMapper _mapper;

        public SongsController(ISongsRepository songsRepository, IMapper mapper)
        {
            this._songsRepository = songsRepository;
            this._mapper = mapper;
        }

        // GET: Songs
        public async Task<IActionResult> Index(string id = "Name_asc")
        {
            SongOrderBy order = SongOrderBy.Name_asc;

            Enum.TryParse(id, true, out order);

            var songs = await _songsRepository.GetAllAsync();

            var songDtos = SortingHelper.SortSongs(_mapper.Map<List<SongDto>>(songs), order);

            return View(songDtos);
        }

        // GET: Songs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || !_songsRepository.HasEntries(SelectType.Song))
            {
                return NotFound();
            }

            var song = await _songsRepository.GetDetails((int)id);
            if (song == null)
            {
                return NotFound();
            }
            var songDetailsDto = _mapper.Map<SongDetailsDto>(song);
            return View(songDetailsDto);
        }

        // GET: Songs/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.ArtistList = _songsRepository.GetSelectListAsync(SelectType.Artist);
            ViewData["AlbumId"] = _songsRepository.GetSelectListAsync(SelectType.Album);
            return View();
        }

        // POST: Songs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Length,Comment,BillBoardRank,BillBoardDate,Writer,ArtistIds,AlbumId")] CreateSongDto createSongDto)
        {
            if (ModelState.IsValid)
            {
                createSongDto.SetArtists();
                
                var song = _mapper.Map<Song>(createSongDto);
                
                await _songsRepository.AddAsync(song);


                return RedirectToAction(nameof(Index));
            }

            ViewBag.ArtistList = _songsRepository.GetSelectListAsync(SelectType.Artist);
            ViewData["AlbumId"] = _songsRepository.GetSelectListAsync(SelectType.Album, null, createSongDto.AlbumId);
            return View(createSongDto);
        }

        // GET: Songs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || !_songsRepository.HasEntries(SelectType.Song))
            {
                return NotFound();
            }

            var song = await _songsRepository.GetDetails((int)id);
         
            if (song == null)
            {
                return NotFound();
            }

            var updateSongDto = _mapper.Map<UpdateSongDto>(song);
            updateSongDto.ArtistIds = song.Artists.Select(x=>x.Id).ToList<int>();

            ViewBag.ArtistList = _songsRepository.GetSelectListAsync(SelectType.Artist, updateSongDto.ArtistIds);
            ViewData["AlbumId"] = _songsRepository.GetSelectListAsync(SelectType.Album, null, updateSongDto.AlbumId);
            return View(updateSongDto);
        }

        // POST: Songs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Length,Comment,BillBoardRank,BillBoardDate,ArtistIds,Writer,AlbumId")] UpdateSongDto updateSongDto)
        {
            if (id != updateSongDto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _songsRepository.UpdateAsync(updateSongDto);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _songsRepository.Exists(updateSongDto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.ArtistList = _songsRepository.GetSelectListAsync(SelectType.Artist);
            ViewData["AlbumId"] = _songsRepository.GetSelectListAsync(SelectType.Album, null, updateSongDto.AlbumId);
            return View(updateSongDto);
        }

        // GET: Songs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || !_songsRepository.HasEntries(SelectType.Song))
            {
                return NotFound();
            }

            var song = await _songsRepository.GetDetails((int)id);
            if (song == null)
            {
                return NotFound();
            }
            var songDto = _mapper.Map<SongDetailsDto>(song);
            return View(songDto);
        }

        // POST: Songs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!_songsRepository.HasEntries(SelectType.Song))
            {
                return Problem("Entity set 'MusicDbContext.Songs'  is null.");
            }
            if (await _songsRepository.Exists(id))
            {
                await _songsRepository.DeleteAsync(id);
            }
            
            return RedirectToAction(nameof(Index));
        }
    }
}
