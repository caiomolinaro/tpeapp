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
    public class PrivilegesController : Controller
    {
        private readonly AppDbContext _context;

        public PrivilegesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Privileges
        public async Task<IActionResult> Index()
        {
              return View(await _context.Privilegios.ToListAsync());
        }

        // GET: Privileges/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Privilegios == null)
            {
                return NotFound();
            }

            var privilegesModel = await _context.Privilegios
                .FirstOrDefaultAsync(m => m.PrivilegesId == id);
            if (privilegesModel == null)
            {
                return NotFound();
            }

            return View(privilegesModel);
        }

        // GET: Privileges/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Privileges/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PrivilegesId,IsPublisher,IsPioneer,IsMinisterialServant,IsElder,IsPioneerAndMinisterialServant,IsPioneerAndElder")] PrivilegesModel privilegesModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(privilegesModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(privilegesModel);
        }

        // GET: Privileges/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Privilegios == null)
            {
                return NotFound();
            }

            var privilegesModel = await _context.Privilegios.FindAsync(id);
            if (privilegesModel == null)
            {
                return NotFound();
            }
            return View(privilegesModel);
        }

        // POST: Privileges/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PrivilegesId,IsPublisher,IsPioneer,IsMinisterialServant,IsElder,IsPioneerAndMinisterialServant,IsPioneerAndElder")] PrivilegesModel privilegesModel)
        {
            if (id != privilegesModel.PrivilegesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(privilegesModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrivilegesModelExists(privilegesModel.PrivilegesId))
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
            return View(privilegesModel);
        }

        // GET: Privileges/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Privilegios == null)
            {
                return NotFound();
            }

            var privilegesModel = await _context.Privilegios
                .FirstOrDefaultAsync(m => m.PrivilegesId == id);
            if (privilegesModel == null)
            {
                return NotFound();
            }

            return View(privilegesModel);
        }

        // POST: Privileges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Privilegios == null)
            {
                return Problem("Entity set 'AppDbContext.Privilegios'  is null.");
            }
            var privilegesModel = await _context.Privilegios.FindAsync(id);
            if (privilegesModel != null)
            {
                _context.Privilegios.Remove(privilegesModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrivilegesModelExists(int id)
        {
          return _context.Privilegios.Any(e => e.PrivilegesId == id);
        }
    }
}
