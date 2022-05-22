using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MotocycleShop.Data;
using MotocycleShop.Models;

namespace MotocycleShop.Controllers
{
    public class KhoesController : Controller
    {
        private readonly MotocycleShopContext _context;

        public KhoesController(MotocycleShopContext context)
        {
            _context = context;
        }

        // GET: Khoes
        public async Task<IActionResult> Index(string khoPhanKhuc, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> phankhucQuery = from b in _context.Kho
                                               orderby b.PhanKhuc
                                               select b.PhanKhuc;
            var khoes = from b in _context.Kho
                        select b;
            if (!string.IsNullOrEmpty(searchString))
            {
                khoes = khoes.Where(s => s.Ten!.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(khoPhanKhuc))
            {
                khoes = khoes.Where(x => x.PhanKhuc == khoPhanKhuc);
            }
            var khoPhanKhucVM = new KhoPhanKhucViewModel
            {
                PhanKhuc = new SelectList(await
            phankhucQuery.Distinct().ToListAsync()),
                Khoes = await khoes.ToListAsync()
            };
            return View(khoPhanKhucVM);
        }

        public async Task<IActionResult> User(string khoPhanKhuc, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> phankhucQuery = from b in _context.Kho
                                               orderby b.PhanKhuc
                                               select b.PhanKhuc;
            var khoes = from b in _context.Kho
                        select b;
            if (!string.IsNullOrEmpty(searchString))
            {
                khoes = khoes.Where(s => s.Ten!.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(khoPhanKhuc))
            {
                khoes = khoes.Where(x => x.PhanKhuc == khoPhanKhuc);
            }
            var khoPhanKhucVM = new KhoPhanKhucViewModel
            {
                PhanKhuc = new SelectList(await
            phankhucQuery.Distinct().ToListAsync()),
                Khoes = await khoes.ToListAsync()
            };
            return View(khoPhanKhucVM);
        }

        // GET: Khoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kho = await _context.Kho
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kho == null)
            {
                return NotFound();
            }

            return View(kho);
        }

        public async Task<IActionResult> UserDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kho = await _context.Kho
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kho == null)
            {
                return NotFound();
            }

            return View(kho);
        }
        // GET: Khoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Khoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ten,NgayNhap,PhanKhuc,Gia,Loai")] Kho kho)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kho);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kho);
        }

        // GET: Khoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kho = await _context.Kho.FindAsync(id);
            if (kho == null)
            {
                return NotFound();
            }
            return View(kho);
        }

        // POST: Khoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ten,NgayNhap,PhanKhuc,Gia,Loai")] Kho kho)
        {
            if (id != kho.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kho);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhoExists(kho.Id))
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
            return View(kho);
        }

        // GET: Khoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kho = await _context.Kho
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kho == null)
            {
                return NotFound();
            }

            return View(kho);
        }

        // POST: Khoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kho = await _context.Kho.FindAsync(id);
            _context.Kho.Remove(kho);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhoExists(int id)
        {
            return _context.Kho.Any(e => e.Id == id);
        }
    }
}
