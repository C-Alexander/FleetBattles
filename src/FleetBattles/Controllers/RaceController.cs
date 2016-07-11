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
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RaceController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Race
        public async Task<IActionResult> Index()
        {
            return View(await _context.Races.ToListAsync());
        }

        // GET: Race/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var race = await _context.Races.SingleOrDefaultAsync(m => m.RaceId == id);
            if (race == null)
            {
                return NotFound();
            }

            return View(race);
        }

        // GET: Race/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Race/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RaceId,Adjective,AvatarURL,Name")] Race race)
        {
            if (ModelState.IsValid)
            {
                _context.Add(race);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(race);
        }

        // GET: Race/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var race = await _context.Races.SingleOrDefaultAsync(m => m.RaceId == id);
            if (race == null)
            {
                return NotFound();
            }
            return View(race);
        }

        // POST: Race/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RaceId,Adjective,AvatarURL,Name")] Race race)
        {
            if (id != race.RaceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(race);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RaceExists(race.RaceId))
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
            return View(race);
        }

        // GET: Race/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var race = await _context.Races.SingleOrDefaultAsync(m => m.RaceId == id);
            if (race == null)
            {
                return NotFound();
            }

            return View(race);
        }

        // POST: Race/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var race = await _context.Races.SingleOrDefaultAsync(m => m.RaceId == id);
            _context.Races.Remove(race);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool RaceExists(int id)
        {
            return _context.Races.Any(e => e.RaceId == id);
        }
    }
}
