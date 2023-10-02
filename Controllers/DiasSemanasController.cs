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
    public class DiasSemanasController : Controller
    {
        private readonly AppDbContext _context;

        public DiasSemanasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: DiasSemanas
        public async Task<IActionResult> Index()
        {
              return View(await _context.DiasSemana.ToListAsync());
        }

        // GET: DiasSemanas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DiasSemana == null)
            {
                return NotFound();
            }

            var diasSemana = await _context.DiasSemana
                .FirstOrDefaultAsync(m => m.DiaSemanaId == id);
            if (diasSemana == null)
            {
                return NotFound();
            }

            return View(diasSemana);
        }

        // GET: DiasSemanas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DiasSemanas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DiaSemanaId,SegundaFeira,TercaFeira,QuartaFeira,QuintaFeira,SextaFeira,Sabado,Domingo")] DiasSemana diasSemana)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diasSemana);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diasSemana);
        }

        // GET: DiasSemanas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DiasSemana == null)
            {
                return NotFound();
            }

            var diasSemana = await _context.DiasSemana.FindAsync(id);
            if (diasSemana == null)
            {
                return NotFound();
            }
            return View(diasSemana);
        }

        // POST: DiasSemanas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DiaSemanaId,SegundaFeira,TercaFeira,QuartaFeira,QuintaFeira,SextaFeira,Sabado,Domingo")] DiasSemana diasSemana)
        {
            if (id != diasSemana.DiaSemanaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diasSemana);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiasSemanaExists(diasSemana.DiaSemanaId))
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
            return View(diasSemana);
        }

        // GET: DiasSemanas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DiasSemana == null)
            {
                return NotFound();
            }

            var diasSemana = await _context.DiasSemana
                .FirstOrDefaultAsync(m => m.DiaSemanaId == id);
            if (diasSemana == null)
            {
                return NotFound();
            }

            return View(diasSemana);
        }

        // POST: DiasSemanas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DiasSemana == null)
            {
                return Problem("Entity set 'AppDbContext.DiasSemana'  is null.");
            }
            var diasSemana = await _context.DiasSemana.FindAsync(id);
            if (diasSemana != null)
            {
                _context.DiasSemana.Remove(diasSemana);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiasSemanaExists(int id)
        {
          return _context.DiasSemana.Any(e => e.DiaSemanaId == id);
        }
    }
}
