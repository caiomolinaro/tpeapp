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
    public class UsersSchedulesController : Controller
    {
        private readonly AppDbContext _context;

        public UsersSchedulesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: UsersSchedules
        public async Task<IActionResult> Index()
        {
              return View(await _context.UsersSchedules.ToListAsync());
        }

        // GET: UsersSchedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.UsersSchedules == null)
            {
                return NotFound();
            }

            var usersSchedulesModel = await _context.UsersSchedules
                .FirstOrDefaultAsync(m => m.SchedulesId == id);
            if (usersSchedulesModel == null)
            {
                return NotFound();
            }

            return View(usersSchedulesModel);
        }

        // GET: UsersSchedules/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsersSchedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SchedulesId,UserId,SchedulesName,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday")] UsersSchedulesModel usersSchedulesModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usersSchedulesModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usersSchedulesModel);
        }

        // GET: UsersSchedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.UsersSchedules == null)
            {
                return NotFound();
            }

            var usersSchedulesModel = await _context.UsersSchedules.FindAsync(id);
            if (usersSchedulesModel == null)
            {
                return NotFound();
            }
            return View(usersSchedulesModel);
        }

        // POST: UsersSchedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SchedulesId,UserId,SchedulesName,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday")] UsersSchedulesModel usersSchedulesModel)
        {
            if (id != usersSchedulesModel.SchedulesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usersSchedulesModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersSchedulesModelExists(usersSchedulesModel.SchedulesId))
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
            return View(usersSchedulesModel);
        }

        // GET: UsersSchedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.UsersSchedules == null)
            {
                return NotFound();
            }

            var usersSchedulesModel = await _context.UsersSchedules
                .FirstOrDefaultAsync(m => m.SchedulesId == id);
            if (usersSchedulesModel == null)
            {
                return NotFound();
            }

            return View(usersSchedulesModel);
        }

        // POST: UsersSchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.UsersSchedules == null)
            {
                return Problem("Entity set 'AppDbContext.UsersSchedules'  is null.");
            }
            var usersSchedulesModel = await _context.UsersSchedules.FindAsync(id);
            if (usersSchedulesModel != null)
            {
                _context.UsersSchedules.Remove(usersSchedulesModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersSchedulesModelExists(int id)
        {
          return _context.UsersSchedules.Any(e => e.SchedulesId == id);
        }
    }
}
