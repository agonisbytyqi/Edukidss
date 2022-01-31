using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using leave_management.Data;
using leave_management.Models;
using Microsoft.AspNetCore.Authorization;

namespace leave_management.Controllers
{
    [Authorize]
    public class HomeWorkController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeWorkController(ApplicationDbContext context)
        {
            _context = context;
        } 
        [Authorize]
        // GET: HomeWork
        public async Task<IActionResult> Index() 
        {
            return View(await _context.HomeWork.ToListAsync());
        }
        [Authorize(Roles = "Administrator,Teacher")]
        // GET: HomeWork/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeWork = await _context.HomeWork
                .FirstOrDefaultAsync(m => m.ID == id);
            if (homeWork == null)
            {
                return NotFound();
            }

            return View(homeWork);
        }
        [Authorize(Roles = "Administrator,Teacher")]
        // GET: HomeWork/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HomeWork/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrator,Teacher")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,NameOfHomeWork,DateOfPublication,Deadline")] HomeWork homeWork)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homeWork);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeWork);
        }
        [Authorize(Roles = "Administrator,Teacher")]
        // GET: HomeWork/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeWork = await _context.HomeWork.FindAsync(id);
            if (homeWork == null)
            {
                return NotFound();
            }
            return View(homeWork);
        }

        // POST: HomeWork/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrator,Teacher")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,NameOfHomeWork,DateOfPublication,Deadline")] HomeWork homeWork)
        {
            if (id != homeWork.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeWork);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeWorkExists(homeWork.ID))
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
            return View(homeWork);
        }
        [Authorize(Roles = "Administrator,Teacher")]
        // GET: HomeWork/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeWork = await _context.HomeWork
                .FirstOrDefaultAsync(m => m.ID == id);
            if (homeWork == null)
            {
                return NotFound();
            }

            return View(homeWork);
        }
        [Authorize(Roles = "Administrator,Teacher")]
        // POST: HomeWork/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeWork = await _context.HomeWork.FindAsync(id);
            _context.HomeWork.Remove(homeWork);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeWorkExists(int id)
        {
            return _context.HomeWork.Any(e => e.ID == id);
        }
    }
}
