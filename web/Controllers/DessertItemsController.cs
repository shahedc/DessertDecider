using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using web.Data;
using web.Models.DessertModels;

namespace web.Controllers
{
    public class DessertItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DessertItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DessertItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.DessertItems.ToListAsync());
        }

        // GET: DessertItems/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dessertItem = await _context.DessertItems
                .SingleOrDefaultAsync(m => m.Id == id);
            if (dessertItem == null)
            {
                return NotFound();
            }

            return View(dessertItem);
        }

        // GET: DessertItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DessertItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Points")] DessertItem dessertItem)
        {
            if (ModelState.IsValid)
            {
                dessertItem.Id = Guid.NewGuid();
                _context.Add(dessertItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dessertItem);
        }

        // GET: DessertItems/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dessertItem = await _context.DessertItems.SingleOrDefaultAsync(m => m.Id == id);
            if (dessertItem == null)
            {
                return NotFound();
            }
            return View(dessertItem);
        }

        // POST: DessertItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Points")] DessertItem dessertItem)
        {
            if (id != dessertItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dessertItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DessertItemExists(dessertItem.Id))
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
            return View(dessertItem);
        }

        // GET: DessertItems/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dessertItem = await _context.DessertItems
                .SingleOrDefaultAsync(m => m.Id == id);
            if (dessertItem == null)
            {
                return NotFound();
            }

            return View(dessertItem);
        }

        // POST: DessertItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var dessertItem = await _context.DessertItems.SingleOrDefaultAsync(m => m.Id == id);
            _context.DessertItems.Remove(dessertItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DessertItemExists(Guid id)
        {
            return _context.DessertItems.Any(e => e.Id == id);
        }
    }
}
