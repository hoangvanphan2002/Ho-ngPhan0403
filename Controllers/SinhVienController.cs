using HoangVanPhan0403.Data;
using HoangVanPhan0403.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HoangVanPhan0403.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SinhVienController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task< IActionResult> Index()
        {
            var model = await _context.SinhVien.ToListAsync();
            return View(model);
        }
         public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("SinhVienId,FullName,Address")] SinhVien sinhvien)
        {
            if(ModelState.IsValid)
            {
                _context.Add(sinhvien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(sinhvien);
        }
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.SinhVien == null)
            {
                return NotFound();
            }

            var sinhVien = await _context.SinhVien.FindAsync(id);
            if (sinhVien == null)
            {
                return NotFound();
            }
            return View(sinhVien);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(string id, [Bind("SinhVienId,FullName,Address")] SinhVien sinhVien)
        {
            if(id != sinhVien.SinhVienId)
            {
                return NotFound();
            }


            if(ModelState.IsValid)
            {
                try
                {
                    _context.Update(sinhVien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if(!SinhVienExists(sinhVien.SinhVienId))
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

            return View(sinhVien);
        }
         public async Task<IActionResult> Delete(string id)
        {
            if(id == null || _context.SinhVien == null)
            {
                return NotFound();
            }
            var sinhVien = await _context.SinhVien.FirstOrDefaultAsync(m=>m.SinhVienId ==id);
            if(sinhVien == null)
            {
                return NotFound();
            }
            return View(sinhVien);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if(_context.SinhVien == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Person' is null");
            }
            var sinhVien = await _context.SinhVien.FindAsync(id);
            if(sinhVien != null)
            {
                _context.SinhVien.Remove(sinhVien);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
          public async Task<IActionResult> Delete(string id)
        {
            if(id == null || _context.SinhVien == null)
            {
                return NotFound();
            }
            var sinhVien = await _context.SinhVien.FirstOrDefaultAsync(m=>m.SinhVienId ==id);
            if(sinhVien == null)
            {
                return NotFound();
            }
            return View(sinhVien);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if(_context.SinhVien == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SinhVien' is null");
            }
            var sinhVien = await _context.SinhVien.FindAsync(id);
            if(sinhVien != null)
            {
                _context.SinhVien.Remove(sinhVien);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        
    }
}