using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Khuselo_BatteryCheck_r1.Models;
using Microsoft.AspNetCore.Authorization;

namespace Khuselo_BatteryCheck_r1.Controllers
{
    [Authorize]
    public class KhuseloDb3Controller : Controller
    {

        private readonly Khuselo_3Context _context;

        public KhuseloDb3Controller(Khuselo_3Context context)
        {
            _context = context;
        }

        public bool isID = false;
        public bool isSerial = false;
        public bool isBrand = false;
        public bool isDatePurchased = false;
        public bool isLocation = false;

        public bool isTelevonic = false;
        public bool isVertel = false;
        public bool isElecta = false;

        

        


        // GET: KhuseloDb3
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["GetSearch"] = searchString;
            var searQuery = from x in _context.KhuseloDb3s select x;
            if (!(string.IsNullOrEmpty(searchString)))
            {

                searQuery = (searQuery.Where(x => x.Id.Equals(Convert.ToInt32(searchString))));
                return View(await searQuery.AsNoTracking().ToListAsync());
            }
            //if (isSerial)
            //{
            //    searQuery = (searQuery.Where(x => x.SerialNumber.Equals(Convert.ToInt32(searchString))));
            //    return View(await searQuery.AsNoTracking().ToListAsync());
            //}
            //if (isBrand)
            //{
            //    searQuery = searQuery.Where(x => x.Brand.Equals(searchString));
            //    return View(await searQuery.AsNoTracking().ToListAsync());
            //}

            else
            {
                return _context.KhuseloDb3s != null ?
            View(await _context.KhuseloDb3s.ToListAsync()) :
            Problem("Entity set 'Khuselo_3Context.KhuseloDb4s'  is null.");
            }
        }

        public async Task<IActionResult> Index2(string searchString)
        {
            ViewData["GetSearch"] = searchString;
            var searQuery = from x in _context.KhuseloDb3s select x;
            if (!(string.IsNullOrEmpty(searchString)))
            {

                searQuery = (searQuery.Where(x => x.Id.Equals(Convert.ToInt32(searchString))));
                return View(await searQuery.AsNoTracking().ToListAsync());
            }

            else
            {
                return _context.KhuseloDb3s != null ?
            View(await _context.KhuseloDb3s.ToListAsync()) :
            Problem("Entity set 'Khuselo_3Context.KhuseloDb4s'  is null.");
            }
        }

        public async Task<IActionResult> Index3(string searchString)
        {
            ViewData["GetSearch"] = searchString;
            var searQuery = from x in _context.KhuseloDb3s select x;
            if (!(string.IsNullOrEmpty(searchString)))
            {

                searQuery = (searQuery.Where(x => x.Id.Equals(Convert.ToInt32(searchString))));
                return View(await searQuery.AsNoTracking().ToListAsync());
            }

            else
            {
                return _context.KhuseloDb3s != null ?
            View(await _context.KhuseloDb3s.ToListAsync()) :
            Problem("Entity set 'Khuselo_3Context.KhuseloDb4s'  is null.");
            }
        }

        public async Task<IActionResult> Index4(string searchString)
        {
            ViewData["GetSearch"] = searchString;
            var searQuery = from x in _context.KhuseloDb3s select x;
            if (!(string.IsNullOrEmpty(searchString)))
            {

                searQuery = (searQuery.Where(x => x.Id.Equals(Convert.ToInt32(searchString))));
                return View(await searQuery.AsNoTracking().ToListAsync());
            }

            else
            {
                return _context.KhuseloDb3s != null ?
            View(await _context.KhuseloDb3s.ToListAsync()) :
            Problem("Entity set 'Khuselo_3Context.KhuseloDb4s'  is null.");
            }
        }

        // GET: KhuseloDb3/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.KhuseloDb3s == null)
            {
                return NotFound();
            }

            var khuseloDb3 = await _context.KhuseloDb3s
                .FirstOrDefaultAsync(m => m.Id == id);
            if (khuseloDb3 == null)
            {
                return NotFound();
            }

            return View(khuseloDb3);
        }

        // GET: KhuseloDb3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KhuseloDb3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SerialNumber,Brand,DatePurchased,DateExpired,Lifespan,Location,TechName,TechCell,Branch,ChargeCycles,DateInstalled")] KhuseloDb3 khuseloDb3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khuseloDb3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khuseloDb3);
        }

        // GET: KhuseloDb3/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.KhuseloDb3s == null)
            {
                return NotFound();
            }

            var khuseloDb3 = await _context.KhuseloDb3s.FindAsync(id);
            if (khuseloDb3 == null)
            {
                return NotFound();
            }
            return View(khuseloDb3);
        }

        // POST: KhuseloDb3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SerialNumber,Brand,DatePurchased,DateExpired,Lifespan,Location,TechName,TechCell,Branch,ChargeCycles,DateInstalled")] KhuseloDb3 khuseloDb3)
        {
            if (id != khuseloDb3.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khuseloDb3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhuseloDb3Exists(khuseloDb3.Id))
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
            return View(khuseloDb3);
        }

        // GET: KhuseloDb3/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.KhuseloDb3s == null)
            {
                return NotFound();
            }

            var khuseloDb3 = await _context.KhuseloDb3s
                .FirstOrDefaultAsync(m => m.Id == id);
            if (khuseloDb3 == null)
            {
                return NotFound();
            }

            return View(khuseloDb3);
        }

        // POST: KhuseloDb3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.KhuseloDb3s == null)
            {
                return Problem("Entity set 'Khuselo_3Context.KhuseloDb3s'  is null.");
            }
            var khuseloDb3 = await _context.KhuseloDb3s.FindAsync(id);
            if (khuseloDb3 != null)
            {
                _context.KhuseloDb3s.Remove(khuseloDb3);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhuseloDb3Exists(int id)
        {
          return (_context.KhuseloDb3s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
