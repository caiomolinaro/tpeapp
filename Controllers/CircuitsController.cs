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
    public class CircuitsController : Controller
    {
        private readonly AppDbContext _context;

        public CircuitsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Circuits
        public async Task<IActionResult> Index()
        {
              return View(await _context.Circuits.ToListAsync());
        }

        // GET: Circuits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Circuits == null)
            {
                return NotFound();
            }

            var circuitsModel = await _context.Circuits
                .FirstOrDefaultAsync(m => m.CircuitId == id);
            if (circuitsModel == null)
            {
                return NotFound();
            }

            return View(circuitsModel);
        }

        // GET: Circuits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Circuits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CircuitId,CircuitName")] CircuitsModel circuitsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(circuitsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(circuitsModel);
        }

        // GET: Circuits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Circuits == null)
            {
                return NotFound();
            }

            var circuitsModel = await _context.Circuits.FindAsync(id);
            if (circuitsModel == null)
            {
                return NotFound();
            }
            return View(circuitsModel);
        }

        // POST: Circuits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CircuitId,CircuitName")] CircuitsModel circuitsModel)
        {
            if (id != circuitsModel.CircuitId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(circuitsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CircuitsModelExists(circuitsModel.CircuitId))
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
            return View(circuitsModel);
        }

        // GET: Circuits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Circuits == null)
            {
                return NotFound();
            }

            var circuitsModel = await _context.Circuits
                .FirstOrDefaultAsync(m => m.CircuitId == id);
            if (circuitsModel == null)
            {
                return NotFound();
            }

            return View(circuitsModel);
        }

        // POST: Circuits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Circuits == null)
            {
                return Problem("Entity set 'AppDbContext.Circuits'  is null.");
            }
            var circuitsModel = await _context.Circuits.FindAsync(id);
            if (circuitsModel != null)
            {
                _context.Circuits.Remove(circuitsModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CircuitsModelExists(int id)
        {
          return _context.Circuits.Any(e => e.CircuitId == id);
        }
    }
}
