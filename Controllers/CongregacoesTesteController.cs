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
    public class CongregacoesTesteController : Controller
    {
        private readonly AppDbContext _context;

        public CongregacoesTesteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CongregacoesTeste
        public async Task<IActionResult> Index()
        {
              return View(await _context.Congregacoes.ToListAsync());
        }

        // GET: CongregacoesTeste/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Congregacoes == null)
            {
                return NotFound();
            }

            var congregacoes = await _context.Congregacoes
                .FirstOrDefaultAsync(m => m.CongregacaoId == id);
            if (congregacoes == null)
            {
                return NotFound();
            }

            return View(congregacoes);
        }

        // GET: CongregacoesTeste/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CongregacoesTeste/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CongregacaoId,CongregacaoNome")] Congregacoes congregacoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(congregacoes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(congregacoes);
        }

        // GET: CongregacoesTeste/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Congregacoes == null)
            {
                return NotFound();
            }

            var congregacoes = await _context.Congregacoes.FindAsync(id);
            if (congregacoes == null)
            {
                return NotFound();
            }
            return View(congregacoes);
        }

        // POST: CongregacoesTeste/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CongregacaoId,CongregacaoNome")] Congregacoes congregacoes)
        {
            if (id != congregacoes.CongregacaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(congregacoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CongregacoesExists(congregacoes.CongregacaoId))
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
            return View(congregacoes);
        }

        // GET: CongregacoesTeste/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Congregacoes == null)
            {
                return NotFound();
            }

            var congregacoes = await _context.Congregacoes
                .FirstOrDefaultAsync(m => m.CongregacaoId == id);
            if (congregacoes == null)
            {
                return NotFound();
            }

            return View(congregacoes);
        }

        // POST: CongregacoesTeste/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Congregacoes == null)
            {
                return Problem("Entity set 'AppDbContext.Congregacoes'  is null.");
            }
            var congregacoes = await _context.Congregacoes.FindAsync(id);
            if (congregacoes != null)
            {
                _context.Congregacoes.Remove(congregacoes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CongregacoesExists(int id)
        {
          return _context.Congregacoes.Any(e => e.CongregacaoId == id);
        }
    }
}
