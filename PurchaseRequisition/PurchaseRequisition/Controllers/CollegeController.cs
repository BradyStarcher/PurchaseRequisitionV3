using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PurchaseRequisition.Data;
using PurchaseRequisition.Models;

namespace PurchaseRequisition.Controllers
{
    public class CollegeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CollegeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: College
        public async Task<IActionResult> Index()
        {
            return View(await _context.College.ToListAsync());
        }

        // GET: College/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var college = await _context.College
                .FirstOrDefaultAsync(m => m.ID == id);
            if (college == null)
            {
                return NotFound();
            }

            return View(college);
        }

        // GET: College/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: College/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] College college)
        {
            if (ModelState.IsValid)
            {
                _context.Add(college);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(college);
        }

        // GET: College/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var college = await _context.College.FindAsync(id);
            if (college == null)
            {
                return NotFound();
            }
            return View(college);
        }

        // POST: College/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] College college)
        {
            if (id != college.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(college);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CollegeExists(college.ID))
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
            return View(college);
        }

        // GET: College/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var college = await _context.College
                .FirstOrDefaultAsync(m => m.ID == id);
            if (college == null)
            {
                return NotFound();
            }

            return View(college);
        }

        // POST: College/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var college = await _context.College.FindAsync(id);
            _context.College.Remove(college);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CollegeExists(int id)
        {
            return _context.College.Any(e => e.ID == id);
        }
    }
}
