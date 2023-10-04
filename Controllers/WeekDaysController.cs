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
    public class WeekDaysController : Controller
    {
        private readonly AppDbContext _context;

        public WeekDaysController(AppDbContext context)
        {
            _context = context;
        }

        // GET: WeekDays
        public async Task<IActionResult> Index()
        {
              return View(await _context.WeekDays.ToListAsync());
        }

        // GET: WeekDays/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.WeekDays == null)
            {
                return NotFound();
            }

            var weekDaysModel = await _context.WeekDays
                .FirstOrDefaultAsync(m => m.WeekDayId == id);
            if (weekDaysModel == null)
            {
                return NotFound();
            }

            return View(weekDaysModel);
        }

        // GET: WeekDays/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WeekDays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WeekDayId,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday")] WeekDaysModel weekDaysModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(weekDaysModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(weekDaysModel);
        }

        // GET: WeekDays/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.WeekDays == null)
            {
                return NotFound();
            }

            var weekDaysModel = await _context.WeekDays.FindAsync(id);
            if (weekDaysModel == null)
            {
                return NotFound();
            }
            return View(weekDaysModel);
        }

        // POST: WeekDays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WeekDayId,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday")] WeekDaysModel weekDaysModel)
        {
            if (id != weekDaysModel.WeekDayId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(weekDaysModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WeekDaysModelExists(weekDaysModel.WeekDayId))
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
            return View(weekDaysModel);
        }

        // GET: WeekDays/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.WeekDays == null)
            {
                return NotFound();
            }

            var weekDaysModel = await _context.WeekDays
                .FirstOrDefaultAsync(m => m.WeekDayId == id);
            if (weekDaysModel == null)
            {
                return NotFound();
            }

            return View(weekDaysModel);
        }

        // POST: WeekDays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.WeekDays == null)
            {
                return Problem("Entity set 'AppDbContext.DiasSemana'  is null.");
            }
            var weekDaysModel = await _context.WeekDays.FindAsync(id);
            if (weekDaysModel != null)
            {
                _context.WeekDays.Remove(weekDaysModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WeekDaysModelExists(int id)
        {
          return _context.WeekDays.Any(e => e.WeekDayId == id);
        }
    }
}
