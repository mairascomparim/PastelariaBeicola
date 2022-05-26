﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Beicola.Data;
using Beicola.Models;

namespace Beicola.Controllers
{
    public class SubCategoriesController : Controller
    {
        private readonly BeicolaContext _context;

        public SubCategoriesController(BeicolaContext context)
        {
            _context = context;
        }

        // GET: SubCategories
        public async Task<IActionResult> Index()
        {
              return View(await _context.SubCategories.ToListAsync());
        }

        // GET: SubCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SubCategories == null)
            {
                return NotFound();
            }

            var subCategories = await _context.SubCategories
                .FirstOrDefaultAsync(m => m.Id_Subcat == id);
            if (subCategories == null)
            {
                return NotFound();
            }

            return View(subCategories);
        }

        // GET: SubCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SubCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Subcat,Id_Cat,Nm_Subcat,St_Subcat")] SubCategories subCategories)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subCategories);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subCategories);
        }

        // GET: SubCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SubCategories == null)
            {
                return NotFound();
            }

            var subCategories = await _context.SubCategories.FindAsync(id);
            if (subCategories == null)
            {
                return NotFound();
            }
            return View(subCategories);
        }

        // POST: SubCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Subcat,Id_Cat,Nm_Subcat,St_Subcat")] SubCategories subCategories)
        {
            if (id != subCategories.Id_Subcat)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subCategories);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubCategoriesExists(subCategories.Id_Subcat))
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
            return View(subCategories);
        }

        // GET: SubCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SubCategories == null)
            {
                return NotFound();
            }

            var subCategories = await _context.SubCategories
                .FirstOrDefaultAsync(m => m.Id_Subcat == id);
            if (subCategories == null)
            {
                return NotFound();
            }

            return View(subCategories);
        }

        // POST: SubCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SubCategories == null)
            {
                return Problem("Entity set 'BeicolaContext.SubCategories'  is null.");
            }
            var subCategories = await _context.SubCategories.FindAsync(id);
            if (subCategories != null)
            {
                _context.SubCategories.Remove(subCategories);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubCategoriesExists(int id)
        {
          return _context.SubCategories.Any(e => e.Id_Subcat == id);
        }
    }
}
