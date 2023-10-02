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
    public class PontosTesteController : Controller
    {
        private readonly AppDbContext _context;

        public PontosTesteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: PontosTeste
        public async Task<IActionResult> Index()
        {
              return View(await _context.Pontos.ToListAsync());
        }

        // GET: PontosTeste/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pontos == null)
            {
                return NotFound();
            }

            var pontos = await _context.Pontos
                .FirstOrDefaultAsync(m => m.PontosId == id);
            if (pontos == null)
            {
                return NotFound();
            }

            return View(pontos);
        }

        // GET: PontosTeste/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PontosTeste/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PontosId,pontosNome")] Pontos pontos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pontos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pontos);
        }

        // GET: PontosTeste/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pontos == null)
            {
                return NotFound();
            }

            var pontos = await _context.Pontos.FindAsync(id);
            if (pontos == null)
            {
                return NotFound();
            }
            return View(pontos);
        }

        // POST: PontosTeste/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PontosId,pontosNome")] Pontos pontos)
        {
            if (id != pontos.PontosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pontos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PontosExists(pontos.PontosId))
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
            return View(pontos);
        }

        // GET: PontosTeste/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pontos == null)
            {
                return NotFound();
            }

            var pontos = await _context.Pontos
                .FirstOrDefaultAsync(m => m.PontosId == id);
            if (pontos == null)
            {
                return NotFound();
            }

            return View(pontos);
        }

        // POST: PontosTeste/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pontos == null)
            {
                return Problem("Entity set 'AppDbContext.Pontos'  is null.");
            }
            var pontos = await _context.Pontos.FindAsync(id);
            if (pontos != null)
            {
                _context.Pontos.Remove(pontos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PontosExists(int id)
        {
          return _context.Pontos.Any(e => e.PontosId == id);
        }
    }
}
