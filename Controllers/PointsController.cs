﻿using System;
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
    public class PointsController : Controller
    {
        private readonly AppDbContext _context;

        public PointsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Points
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Points.Include(p => p.Schedules);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Points/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Points == null)
            {
                return NotFound();
            }

            var pointsModel = await _context.Points
                .Include(p => p.Schedules)
                .FirstOrDefaultAsync(m => m.PointId == id);
            if (pointsModel == null)
            {
                return NotFound();
            }

            return View(pointsModel);
        }

        // GET: Points/Create
        public IActionResult Create()
        {
            ViewData["SchedulesId"] = new SelectList(_context.Schedules, "SchedulesId", "SchedulesId");
            return View();
        }

        // POST: Points/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PointId,PointName,SchedulesId")] PointsModel pointsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pointsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SchedulesId"] = new SelectList(_context.Schedules, "SchedulesId", "SchedulesId", pointsModel.SchedulesId);
            return View(pointsModel);
        }

        // GET: Points/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Points == null)
            {
                return NotFound();
            }

            var pointsModel = await _context.Points.FindAsync(id);
            if (pointsModel == null)
            {
                return NotFound();
            }
            ViewData["SchedulesId"] = new SelectList(_context.Schedules, "SchedulesId", "SchedulesId", pointsModel.SchedulesId);
            return View(pointsModel);
        }

        // POST: Points/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PointId,PointName,SchedulesId")] PointsModel pointsModel)
        {
            if (id != pointsModel.PointId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pointsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PointsModelExists(pointsModel.PointId))
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
            ViewData["SchedulesId"] = new SelectList(_context.Schedules, "SchedulesId", "SchedulesId", pointsModel.SchedulesId);
            return View(pointsModel);
        }

        // GET: Points/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Points == null)
            {
                return NotFound();
            }

            var pointsModel = await _context.Points
                .Include(p => p.Schedules)
                .FirstOrDefaultAsync(m => m.PointId == id);
            if (pointsModel == null)
            {
                return NotFound();
            }

            return View(pointsModel);
        }

        // POST: Points/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Points == null)
            {
                return Problem("Entity set 'AppDbContext.Points'  is null.");
            }
            var pointsModel = await _context.Points.FindAsync(id);
            if (pointsModel != null)
            {
                _context.Points.Remove(pointsModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PointsModelExists(int id)
        {
          return _context.Points.Any(e => e.PointId == id);
        }
    }
}
