using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FleetBattles.Data;
using FleetBattles.Models;
using Microsoft.AspNetCore.Authorization;

namespace FleetBattles.Controllers
{
    [Authorize(Roles = "Admin")]
    public class FactionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FactionController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ACP/Faction
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Factions.Include(f => f.DefaultRace).Include(f => f.DefaultChannel);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ACP/Faction/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faction = await _context.Factions.SingleOrDefaultAsync(m => m.FactionId == id);
            if (faction == null)
            {
                return NotFound();
            }

            return View(faction);
        }

        // GET: ACP/Faction/Create
        public IActionResult Create()
        {
            ViewData["RaceId"] = new SelectList(_context.Races, "RaceId", "Adjective");
            ViewData["ChannelId"] = new SelectList(_context.Channels, "ChannelId", "Name");
            return View();
        }

        // POST: ACP/Faction/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FactionId,Adjective,IconURL,IsPublic,LogoURL,LongName,RaceId,ChannelId,ShortName")] Faction faction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faction);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["RaceId"] = new SelectList(_context.Races, "RaceId", "Adjective", faction.RaceId);
            ViewData["ChannelId"] = new SelectList(_context.Channels, "ChannelId", "Name", faction.ChannelId);
            return View(faction);
        }

        // GET: ACP/Faction/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faction = await _context.Factions.SingleOrDefaultAsync(m => m.FactionId == id);
            if (faction == null)
            {
                return NotFound();
            }
            ViewData["RaceId"] = new SelectList(_context.Races, "RaceId", "Adjective", faction.RaceId);
            ViewData["ChannelId"] = new SelectList(_context.Channels, "ChannelId", "Name", faction.ChannelId);
            return View(faction);
        }

        // POST: ACP/Faction/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FactionId,Adjective,IconURL,IsPublic,LogoURL,LongName,RaceId,ChannelId,ShortName")] Faction faction)
        {
            if (id != faction.FactionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FactionExists(faction.FactionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["RaceId"] = new SelectList(_context.Races, "RaceId", "Adjective", faction.RaceId);
            ViewData["RaceId"] = new SelectList(_context.Channels, "ChannelId", "Name", faction.ChannelId);
            return View(faction);
        }

        // GET: ACP/Faction/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faction = await _context.Factions.SingleOrDefaultAsync(m => m.FactionId == id);
            if (faction == null)
            {
                return NotFound();
            }

            return View(faction);
        }

        // POST: ACP/Faction/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faction = await _context.Factions.SingleOrDefaultAsync(m => m.FactionId == id);
            _context.Factions.Remove(faction);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool FactionExists(int id)
        {
            return _context.Factions.Any(e => e.FactionId == id);
        }
    }
}
