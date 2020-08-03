using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DejandoHuella.Data;
using DejandoHuella.Models;

namespace DejandoHuella.Controllers
{
    public class BodegasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BodegasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bodegas
        public async Task<IActionResult> Index()
        {
            var bodegas = _context.Bodegas
                .Include(c => c.Empresa)
                .AsNoTracking();
            return View(await bodegas  .ToListAsync());
        }

        // GET: Bodegas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bodega = await _context.Bodegas
                .Include(m=>m.Empresa)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bodega == null)
            {
                return NotFound();
            }

            return View(bodega);
        }

        // GET: Bodegas/Create
        public IActionResult Create()
        {
            EmpresasList();
            return View();
        }

        // POST: Bodegas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreProducto,IdEmpresa")] Bodega bodega)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bodega);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            EmpresasList(bodega.IdEmpresa);
            return View(bodega);
        }

        

        // GET: Bodegas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bodega = await _context.Bodegas
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
            if (bodega == null)
            {
                return NotFound();
            }
            EmpresasList(bodega.IdEmpresa);
            return View(bodega);
        }

        // POST: Bodegas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var bodegaUpdate = await _context.Bodegas
             .FirstOrDefaultAsync(b => b.Id == id);
            if (await TryUpdateModelAsync<Bodega>(bodegaUpdate, "", b => b.NombreProducto, b => b.IdEmpresa))
            { 
                try
                {
                    
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException)
                {
                        ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists, " +
                    "see your system administrator.");
                    }
                return RedirectToAction(nameof(Index));
            }
            EmpresasList(bodegaUpdate.IdEmpresa);
            return View(bodegaUpdate);
        }

        private void EmpresasList(object selectedEmpresa = null)
        {
            var empresasQuery = from e in _context.Empresas
                                orderby e.Nombre
                                select e;
            ViewBag.IdEmpresa= new SelectList(empresasQuery.AsNoTracking(), "Id", "Nombre", selectedEmpresa);
        }

        // GET: Bodegas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bodega = await _context.Bodegas
                .Include(m => m.Empresa)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bodega == null)
            {
                return NotFound();
            }

            return View(bodega);
        }

        // POST: Bodegas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bodega = await _context.Bodegas.FindAsync(id);
            _context.Bodegas.Remove(bodega);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BodegaExists(int id)
        {
            return _context.Bodegas.Any(e => e.Id == id);
        }
    }
}
