using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tpeapp.Context;
using tpeapp.Models;

namespace tpeapp.Controllers
{
    public class SchedulesTesteController : Controller
    {
        private readonly AppDbContext _context;

        public SchedulesTesteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: SchedulesTeste
        public async Task<IActionResult> Index()
        {
              return View(await _context.Horarios.ToListAsync());
        }

        // GET: SchedulesTeste/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Horarios == null)
            {
                return NotFound();
            }

            var schedules = await _context.Horarios
                .FirstOrDefaultAsync(m => m.HorariosId == id);
            if (schedules == null)
            {
                return NotFound();
            }

            return View(schedules);
        }

        // GET: SchedulesTeste/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SchedulesTeste/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HorariosId,TimeName")] Schedules schedules)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schedules);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(schedules);
        }

        // GET: SchedulesTeste/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Horarios == null)
            {
                return NotFound();
            }

            var schedules = await _context.Horarios.FindAsync(id);
            if (schedules == null)
            {
                return NotFound();
            }
            return View(schedules);
        }

        // POST: SchedulesTeste/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HorariosId,TimeName")] Schedules schedules)
        {
            if (id != schedules.HorariosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedules);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchedulesExists(schedules.HorariosId))
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
            return View(schedules);
        }

        // GET: SchedulesTeste/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Horarios == null)
            {
                return NotFound();
            }

            var schedules = await _context.Horarios
                .FirstOrDefaultAsync(m => m.HorariosId == id);
            if (schedules == null)
            {
                return NotFound();
            }

            return View(schedules);
        }

        // POST: SchedulesTeste/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Horarios == null)
            {
                return Problem("Entity set 'AppDbContext.Horarios'  is null.");
            }
            var schedules = await _context.Horarios.FindAsync(id);
            if (schedules != null)
            {
                _context.Horarios.Remove(schedules);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchedulesExists(int id)
        {
          return _context.Horarios.Any(e => e.HorariosId == id);
        }
    }
}
