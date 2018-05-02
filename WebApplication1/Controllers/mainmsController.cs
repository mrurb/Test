using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.data;

namespace WebApplication1.Controllers
{
    public class mainmsController : Controller
    {
        private readonly DBC _context;

        public mainmsController(DBC context)
        {
            _context = context;
        }

        // GET: mainms
        public async Task<IActionResult> Index()
        {
            return View(await _context.mainm.Include(u => u.User1).Include(u => u.User2).Include(u => u.Userlist).ThenInclude(u => u.user).ToListAsync());
        }

        // GET: mainms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainm = await _context.mainm
                .SingleOrDefaultAsync(m => m.Id == id);
            if (mainm == null)
            {
                return NotFound();
            }

            return View(mainm);
        }

        // GET: mainms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: mainms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] mainm mainm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mainm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mainm);
        }

        // GET: mainms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainm = await _context.mainm.SingleOrDefaultAsync(m => m.Id == id);
            if (mainm == null)
            {
                return NotFound();
            }
            return View(mainm);
        }

        // POST: mainms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] mainm mainm)
        {
            if (id != mainm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mainm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!mainmExists(mainm.Id))
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
            return View(mainm);
        }

        // GET: mainms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainm = await _context.mainm
                .SingleOrDefaultAsync(m => m.Id == id);
            if (mainm == null)
            {
                return NotFound();
            }

            return View(mainm);
        }

        // POST: mainms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mainm = await _context.mainm.SingleOrDefaultAsync(m => m.Id == id);
            _context.mainm.Remove(mainm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool mainmExists(int id)
        {
            return _context.mainm.Any(e => e.Id == id);
        }
    }
}
