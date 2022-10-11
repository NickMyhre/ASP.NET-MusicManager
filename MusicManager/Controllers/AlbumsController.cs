using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicManager.Contracts;
using MusicManager.Enumerations;
using MusicManager.Enumerations.Sorting;
using MusicManager.Models;
using MusicManager.Repositories;
using MusicManager.Utility;
using MusicManager.ViewModels.Album;
using NuGet.Packaging;

namespace MusicManager.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly IAlbumsRepository _albumsRepository;
        private readonly IMapper _mapper;

        public AlbumsController(IAlbumsRepository albumsRepository, IMapper mapper)
        {
            this._albumsRepository = albumsRepository;
            this._mapper = mapper;
        }

        // GET: Albums
        public async Task<IActionResult> Index(string id = "Title_asc")
        {
            AlbumOrderBy order = AlbumOrderBy.Title_asc;

            Enum.TryParse(id, true, out order);

            var albums = await _albumsRepository.GetAllAsync();

            var albumDtoList = SortingHelper.SortAlbums(_mapper.Map<List<AlbumDto>>(albums), order);

            return View(albumDtoList);
        }

        // GET: Albums/Details/5
        public async Task<IActionResult> Details(int? id, string orderBy = "Name_asc")
        {
            if (id == null || !_albumsRepository.HasEntries(SelectType.Album))
            {
                return NotFound();
            }

            var album = await _albumsRepository.GetDetails((int)id);
            if (album == null)
            {
                return NotFound();
            }

            SongOrderBy order = SongOrderBy.Name_asc;

            Enum.TryParse(orderBy, true, out order);

            var albumDetailsDto = _mapper.Map<AlbumDetailsDto>(album);

            albumDetailsDto.Songs = SortingHelper.SortSongs(albumDetailsDto.Songs.ToList(), order);
            
            return View(albumDetailsDto);
        }

        // GET: Albums/Create
        public IActionResult Create()
        {
            ViewBag.ArtistList = _albumsRepository.GetSelectListAsync(SelectType.Artist);
            return View();
        }

        // POST: Albums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Label,Genre,ReleaseDate,ArtistIds,Fact")] CreateAlbumDto createAlbumDto)
        {
            if (ModelState.IsValid)
            {
                createAlbumDto.SetArtists();

                var album =_mapper.Map<Album>(createAlbumDto);
                
                await _albumsRepository.AddAsync(album);

                return RedirectToAction(nameof(Index));
            }

            ViewBag.ArtistList = _albumsRepository.GetSelectListAsync(SelectType.Artist, createAlbumDto.ArtistIds);
            return View(createAlbumDto);
        }

        // GET: Albums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || !_albumsRepository.HasEntries(SelectType.Album))
            {
                return NotFound();
            }

            var album = await _albumsRepository.GetDetails((int)id);
            
            if (album == null)
            {
                return NotFound();
            }
            var updateAlbumDto = _mapper.Map<UpdateAlbumDto>(album);
            updateAlbumDto.ArtistIds = album.Artists.Select(x=>x.Id).ToList<int>();
            ViewBag.ArtistList = _albumsRepository.GetSelectListAsync(SelectType.Artist, updateAlbumDto.ArtistIds);
            return View(updateAlbumDto);
        }

        // POST: Albums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Label,Genre,ReleaseDate,ArtistIds,Fact")] UpdateAlbumDto updateAlbumDto)
        {
            if (id != updateAlbumDto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _albumsRepository.UpdateAsync(updateAlbumDto);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _albumsRepository.Exists(id))
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
            ViewBag.ArtistList = _albumsRepository.GetSelectListAsync(SelectType.Artist, updateAlbumDto.ArtistIds);
            return View(updateAlbumDto);
        }

        // GET: Albums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || !_albumsRepository.HasEntries(SelectType.Album))
            {
                return NotFound();
            }

            var album = await _albumsRepository.GetDetails((int)id);
            if (album == null)
            {
                return NotFound();
            }
            var albumDto = _mapper.Map<AlbumDetailsDto>(album);
            return View(albumDto);
        }

        // POST: Albums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!_albumsRepository.HasEntries(SelectType.Album))
            {
                return Problem("Entity set 'MusicDbContext.Albums'  is null.");
            }
            if (await _albumsRepository.Exists(id))
            {
                await _albumsRepository.DeleteAsync(id);
            }
            
            return RedirectToAction(nameof(Index));
        }

    }
}
