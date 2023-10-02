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
    public class UsuariosTestController : Controller
    {
        private readonly AppDbContext _context;

        public UsuariosTestController(AppDbContext context)
        {
            _context = context;
        }

        // GET: UsuariosTest
        public async Task<IActionResult> Index()
        {
              return View(await _context.Usuarios.ToListAsync());
        }

        // GET: UsuariosTest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuarios = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (usuarios == null)
            {
                return NotFound();
            }

            return View(usuarios);
        }

        // GET: UsuariosTest/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsuariosTest/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsuarioId,UsuarioNome,isHomem,isMulher,UsuarioTelefone,UsuarioEmail")] Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuarios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuarios);
        }

        // GET: UsuariosTest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuarios = await _context.Usuarios.FindAsync(id);
            if (usuarios == null)
            {
                return NotFound();
            }
            return View(usuarios);
        }

        // POST: UsuariosTest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsuarioId,UsuarioNome,isHomem,isMulher,UsuarioTelefone,UsuarioEmail")] Usuarios usuarios)
        {
            if (id != usuarios.UsuarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuariosExists(usuarios.UsuarioId))
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
            return View(usuarios);
        }

        // GET: UsuariosTest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuarios = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (usuarios == null)
            {
                return NotFound();
            }

            return View(usuarios);
        }

        // POST: UsuariosTest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Usuarios == null)
            {
                return Problem("Entity set 'AppDbContext.Usuarios'  is null.");
            }
            var usuarios = await _context.Usuarios.FindAsync(id);
            if (usuarios != null)
            {
                _context.Usuarios.Remove(usuarios);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuariosExists(int id)
        {
          return _context.Usuarios.Any(e => e.UsuarioId == id);
        }
    }
}
