using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicManager.Contracts;
using MusicManager.Enumerations.Sorting;
using MusicManager.Models;
using MusicManager.Utility;
using MusicManager.ViewModels.Artist;

namespace MusicManager.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly IArtistsRepository _artistsRepository;
        private readonly IMapper _mapper;

        public ArtistsController(IArtistsRepository artistsRepository, IMapper mapper)
        {
            this._artistsRepository = artistsRepository;
            this._mapper = mapper;
        }

        // GET: Artists
        public async Task<IActionResult> Index(string id = "LastName_asc")
        {
            ArtistOrderBy order = ArtistOrderBy.LastName_asc;

            Enum.TryParse(id, true, out order);
 
            var artists = await _artistsRepository.GetAllAsync();


            var artistDtoList = SortingHelper.SortArtists(_mapper.Map<List<ArtistDto>>(artists), order);
            

            return View(artistDtoList);
        }

        // GET: Artists/Details/5
        public async Task<IActionResult> Details(int? id, string orderBy = "Name_asc")
        {
            if (id == null || !_artistsRepository.HasEntries(Enumerations.SelectType.Artist))
            {
                return NotFound();
            }

            var artist = await _artistsRepository.GetDetails((int)id);
  
            if (artist == null)
            {
                return NotFound();
            }

            SongOrderBy order = SongOrderBy.Name_asc;

            Enum.TryParse(orderBy, true, out order);

            var artistDetailsDto = _mapper.Map<ArtistDetailsDto>(artist);

            artistDetailsDto.Songs = SortingHelper.SortSongs(artistDetailsDto.Songs.ToList(), order);
            return View(artistDetailsDto);
        }

        // GET: Artists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Artists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StageName,BirthName,Hometown,BirthDate,DeathDate,Fact")] CreateArtistDto createArtistDto)
        {
           if (ModelState.IsValid)
            {
                var artist = _mapper.Map<Artist>(createArtistDto);

                await _artistsRepository.AddAsync(artist);
                return RedirectToAction(nameof(Index));
            }
            return View(createArtistDto);
        }

        // GET: Artists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || !_artistsRepository.HasEntries(Enumerations.SelectType.Artist))
            {
                return NotFound();
            }

            var artist = await _artistsRepository.GetAsync(id);
            if (artist == null)
            {
                return NotFound();
            }

            var artistDto = _mapper.Map<ArtistDetailsDto>(artist);
            return View(artistDto);
        }

        // POST: Artists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StageName,BirthName,Hometown,BirthDate,DeathDate,Fact")] UpdateArtistDto updateArtistDto)
        {
            if (id != updateArtistDto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var artist = _mapper.Map<Artist>(updateArtistDto);
                try
                {
                    await _artistsRepository.UpdateAsync(artist);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _artistsRepository.Exists(id))
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
            return View(updateArtistDto);
        }

        // GET: Artists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || !_artistsRepository.HasEntries(Enumerations.SelectType.Artist))
            {
                return NotFound();
            }

            var artist = await _artistsRepository.GetDetails((int)id);
            if (artist == null)
            {
                return NotFound();
            }
            var artistDetailsDto = _mapper.Map<ArtistDetailsDto>(artist);
            return View(artistDetailsDto);
        }

        // POST: Artists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (await _artistsRepository.GetAllAsync() == null)
            {
                return Problem("Entity set 'MusicDbContext.Artists'  is null.");
            }
            if (await _artistsRepository.Exists(id))
            {
                await _artistsRepository.DeleteAsync(id);
            }
            
            return RedirectToAction(nameof(Index));
        }
    }
}
