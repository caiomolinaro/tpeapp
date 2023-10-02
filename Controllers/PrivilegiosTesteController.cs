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
    public class PrivilegiosTesteController : Controller
    {
        private readonly AppDbContext _context;

        public PrivilegiosTesteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: PrivilegiosTeste
        public async Task<IActionResult> Index()
        {
              return View(await _context.Privilegios.ToListAsync());
        }

        // GET: PrivilegiosTeste/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Privilegios == null)
            {
                return NotFound();
            }

            var privilegios = await _context.Privilegios
                .FirstOrDefaultAsync(m => m.PrivilegiosId == id);
            if (privilegios == null)
            {
                return NotFound();
            }

            return View(privilegios);
        }

        // GET: PrivilegiosTeste/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PrivilegiosTeste/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PrivilegiosId,IsPublicador,IsPioneiro,IsServo,IsAnciao,IsPioneiroAndServo,IsPioneroAndAnciao")] Privilegios privilegios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(privilegios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(privilegios);
        }

        // GET: PrivilegiosTeste/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Privilegios == null)
            {
                return NotFound();
            }

            var privilegios = await _context.Privilegios.FindAsync(id);
            if (privilegios == null)
            {
                return NotFound();
            }
            return View(privilegios);
        }

        // POST: PrivilegiosTeste/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PrivilegiosId,IsPublicador,IsPioneiro,IsServo,IsAnciao,IsPioneiroAndServo,IsPioneroAndAnciao")] Privilegios privilegios)
        {
            if (id != privilegios.PrivilegiosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(privilegios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrivilegiosExists(privilegios.PrivilegiosId))
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
            return View(privilegios);
        }

        // GET: PrivilegiosTeste/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Privilegios == null)
            {
                return NotFound();
            }

            var privilegios = await _context.Privilegios
                .FirstOrDefaultAsync(m => m.PrivilegiosId == id);
            if (privilegios == null)
            {
                return NotFound();
            }

            return View(privilegios);
        }

        // POST: PrivilegiosTeste/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Privilegios == null)
            {
                return Problem("Entity set 'AppDbContext.Privilegios'  is null.");
            }
            var privilegios = await _context.Privilegios.FindAsync(id);
            if (privilegios != null)
            {
                _context.Privilegios.Remove(privilegios);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrivilegiosExists(int id)
        {
          return _context.Privilegios.Any(e => e.PrivilegiosId == id);
        }
    }
}
