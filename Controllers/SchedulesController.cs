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
    public class SchedulesController : Controller
    {
        private readonly AppDbContext _context;

        public SchedulesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Schedules
        public async Task<IActionResult> Index()
        {
              return View(await _context.SchedulesModel.ToListAsync());
        }

        // GET: Schedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SchedulesModel == null)
            {
                return NotFound();
            }

            var schedulesModel = await _context.SchedulesModel
                .FirstOrDefaultAsync(m => m.SchedulesId == id);
            if (schedulesModel == null)
            {
                return NotFound();
            }

            return View(schedulesModel);
        }

        // GET: Schedules/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Schedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SchedulesId,SchedulesNamePrincipal,SchedulesName,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday")] SchedulesModel schedulesModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schedulesModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(schedulesModel);
        }

        // GET: Schedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SchedulesModel == null)
            {
                return NotFound();
            }

            var schedulesModel = await _context.SchedulesModel.FindAsync(id);
            if (schedulesModel == null)
            {
                return NotFound();
            }
            return View(schedulesModel);
        }

        // POST: Schedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SchedulesId,SchedulesNamePrincipal,SchedulesName,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday")] SchedulesModel schedulesModel)
        {
            if (id != schedulesModel.SchedulesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedulesModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchedulesModelExists(schedulesModel.SchedulesId))
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
            return View(schedulesModel);
        }

        // GET: Schedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SchedulesModel == null)
            {
                return NotFound();
            }

            var schedulesModel = await _context.SchedulesModel
                .FirstOrDefaultAsync(m => m.SchedulesId == id);
            if (schedulesModel == null)
            {
                return NotFound();
            }

            return View(schedulesModel);
        }

        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SchedulesModel == null)
            {
                return Problem("Entity set 'AppDbContext.SchedulesModel'  is null.");
            }
            var schedulesModel = await _context.SchedulesModel.FindAsync(id);
            if (schedulesModel != null)
            {
                _context.SchedulesModel.Remove(schedulesModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchedulesModelExists(int id)
        {
          return _context.SchedulesModel.Any(e => e.SchedulesId == id);
        }
    }
}
