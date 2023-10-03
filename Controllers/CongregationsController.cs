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
    public class CongregationsController : Controller
    {
        private readonly AppDbContext _context;

        public CongregationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Congregations
        public async Task<IActionResult> Index()
        {
              return View(await _context.Congregacoes.ToListAsync());
        }

        // GET: Congregations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Congregacoes == null)
            {
                return NotFound();
            }

            var congregationsModel = await _context.Congregacoes
                .FirstOrDefaultAsync(m => m.CongregationId == id);
            if (congregationsModel == null)
            {
                return NotFound();
            }

            return View(congregationsModel);
        }

        // GET: Congregations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Congregations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CongregationId,CongregationName")] CongregationsModel congregationsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(congregationsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(congregationsModel);
        }

        // GET: Congregations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Congregacoes == null)
            {
                return NotFound();
            }

            var congregationsModel = await _context.Congregacoes.FindAsync(id);
            if (congregationsModel == null)
            {
                return NotFound();
            }
            return View(congregationsModel);
        }

        // POST: Congregations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CongregationId,CongregationName")] CongregationsModel congregationsModel)
        {
            if (id != congregationsModel.CongregationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(congregationsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CongregationsModelExists(congregationsModel.CongregationId))
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
            return View(congregationsModel);
        }

        // GET: Congregations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Congregacoes == null)
            {
                return NotFound();
            }

            var congregationsModel = await _context.Congregacoes
                .FirstOrDefaultAsync(m => m.CongregationId == id);
            if (congregationsModel == null)
            {
                return NotFound();
            }

            return View(congregationsModel);
        }

        // POST: Congregations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Congregacoes == null)
            {
                return Problem("Entity set 'AppDbContext.Congregacoes'  is null.");
            }
            var congregationsModel = await _context.Congregacoes.FindAsync(id);
            if (congregationsModel != null)
            {
                _context.Congregacoes.Remove(congregationsModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CongregationsModelExists(int id)
        {
          return _context.Congregacoes.Any(e => e.CongregationId == id);
        }
    }
}
