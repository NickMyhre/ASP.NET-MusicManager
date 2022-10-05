using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicManager.Models;
using MusicManager.ViewModels.Artist;

namespace MusicManager.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly MusicDbContext _context;
        private readonly IMapper _mapper;

        public ArtistsController(MusicDbContext context, IMapper mapper)
        {
            _context = context;
            this._mapper = mapper;
        }

        // GET: Artists
        public async Task<IActionResult> Index()
        {
            var artists = await _context.Artists.Include(s => s.Songs).ToListAsync();

            var artistDto = _mapper.Map<List<ArtistDto>>(artists);

            return View(artistDto);
        }

        // GET: Artists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Artists == null)
            {
                return NotFound();
            }

            var artist = await _context.Artists.Include(m => m.Songs).Include(m => m.Albums)
                .FirstOrDefaultAsync(m => m.Id == id);
  
            if (artist == null)
            {
                return NotFound();
            }

            var artistDetailsDto = _mapper.Map<ArtistDetailsDto>(artist);

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
                _context.Add(artist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(createArtistDto);
        }

        // GET: Artists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Artists == null)
            {
                return NotFound();
            }

            var artist = await _context.Artists.FindAsync(id);
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
                    _context.Update(artist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtistExists(artist.Id))
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
            if (id == null || _context.Artists == null)
            {
                return NotFound();
            }

            var artist = await _context.Artists
                .FirstOrDefaultAsync(m => m.Id == id);
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
            if (_context.Artists == null)
            {
                return Problem("Entity set 'MusicDbContext.Artists'  is null.");
            }
            var artist = await _context.Artists.FindAsync(id);
            if (artist != null)
            {
                _context.Artists.Remove(artist);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtistExists(int id)
        {
          return _context.Artists.Any(e => e.Id == id);
        }
    }
}
