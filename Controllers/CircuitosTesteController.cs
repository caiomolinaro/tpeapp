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
    public class CircuitosTesteController : Controller
    {
        private readonly AppDbContext _context;

        public CircuitosTesteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CircuitosTeste
        public async Task<IActionResult> Index()
        {
              return View(await _context.Circuitos.ToListAsync());
        }

        // GET: CircuitosTeste/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Circuitos == null)
            {
                return NotFound();
            }

            var circuitos = await _context.Circuitos
                .FirstOrDefaultAsync(m => m.CircuitoId == id);
            if (circuitos == null)
            {
                return NotFound();
            }

            return View(circuitos);
        }

        // GET: CircuitosTeste/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CircuitosTeste/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CircuitoId,CircuitoNome")] Circuitos circuitos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(circuitos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(circuitos);
        }

        // GET: CircuitosTeste/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Circuitos == null)
            {
                return NotFound();
            }

            var circuitos = await _context.Circuitos.FindAsync(id);
            if (circuitos == null)
            {
                return NotFound();
            }
            return View(circuitos);
        }

        // POST: CircuitosTeste/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CircuitoId,CircuitoNome")] Circuitos circuitos)
        {
            if (id != circuitos.CircuitoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(circuitos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CircuitosExists(circuitos.CircuitoId))
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
            return View(circuitos);
        }

        // GET: CircuitosTeste/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Circuitos == null)
            {
                return NotFound();
            }

            var circuitos = await _context.Circuitos
                .FirstOrDefaultAsync(m => m.CircuitoId == id);
            if (circuitos == null)
            {
                return NotFound();
            }

            return View(circuitos);
        }

        // POST: CircuitosTeste/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Circuitos == null)
            {
                return Problem("Entity set 'AppDbContext.Circuitos'  is null.");
            }
            var circuitos = await _context.Circuitos.FindAsync(id);
            if (circuitos != null)
            {
                _context.Circuitos.Remove(circuitos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CircuitosExists(int id)
        {
          return _context.Circuitos.Any(e => e.CircuitoId == id);
        }
    }
}
