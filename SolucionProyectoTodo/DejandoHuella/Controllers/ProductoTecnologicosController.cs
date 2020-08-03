using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DejandoHuella.Data;
using DejandoHuella.Models;
using Microsoft.AspNetCore.Hosting;
using DejandoHuella.ViewModels;
using System.IO;

namespace DejandoHuella.Controllers
{
    public class ProductoTecnologicosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public ProductoTecnologicosController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        // GET: ProductoTecnologicos
        public async Task<IActionResult> Index()
        {
            var productoTecnologico = await _context.ProductoTecnologicos.ToListAsync();
            return View(productoTecnologico);
        }

        // GET: ProductoTecnologicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoTecnologico = await _context.ProductoTecnologicos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productoTecnologico == null)
            {
                return NotFound();
            }

            return View(productoTecnologico);
        }

        // GET: ProductoTecnologicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductoTecnologicos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductoTecnologicoViewModel productoTecnologicoViewModel)
        {
            if (ModelState.IsValid)
            {
                string unicoArchivo = UploadedFile(productoTecnologicoViewModel);
                ProductoTecnologico productoTecnologico = new ProductoTecnologico
                {
                    NombreProducto=productoTecnologicoViewModel.NombreProducto,
                    Marca=productoTecnologicoViewModel.Marca,
                    Modelo=productoTecnologicoViewModel.Modelo,
                    Costo=productoTecnologicoViewModel.Costo,
                    Medidas=productoTecnologicoViewModel.Medidas,
                    Almacenamiento=productoTecnologicoViewModel.Almacenamiento,
                    TipoSoftware=productoTecnologicoViewModel.TipoSoftware,
                    MemoryRam=productoTecnologicoViewModel.MemoryRam,
                    FotoBase64=unicoArchivo,

                };
                _context.Add(productoTecnologico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        private string UploadedFile(ProductoTecnologicoViewModel productoTecnologicoViewModel)
        {
            string unicoArchivo = null;

            if (productoTecnologicoViewModel.FotoBase64!= null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/ProductoTecnologico");
                unicoArchivo = Guid.NewGuid().ToString() + "_" + productoTecnologicoViewModel.FotoBase64.FileName;
                string filePath = Path.Combine(uploadsFolder, unicoArchivo);
                var fileStream = new FileStream(filePath, FileMode.Create);
                productoTecnologicoViewModel.FotoBase64.CopyTo(fileStream);

            }
            return unicoArchivo;
        }

        // GET: ProductoTecnologicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoTecnologico = await _context.ProductoTecnologicos.FindAsync(id);
            if (productoTecnologico == null)
            {
                return NotFound();
            }
            return View(productoTecnologico);
        }

        // POST: ProductoTecnologicos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Almacenamiento,TipoSoftware,MemoryRam,IdBodega,FotoBase64,NombreProducto,Marca,Modelo,Costo,Medidas")] ProductoTecnologico productoTecnologico)
        {
            if (id != productoTecnologico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productoTecnologico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoTecnologicoExists(productoTecnologico.Id))
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
            return View(productoTecnologico);
        }

        // GET: ProductoTecnologicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoTecnologico = await _context.ProductoTecnologicos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productoTecnologico == null)
            {
                return NotFound();
            }

            return View(productoTecnologico);
        }

        // POST: ProductoTecnologicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productoTecnologico = await _context.ProductoTecnologicos.FindAsync(id);
            _context.ProductoTecnologicos.Remove(productoTecnologico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoTecnologicoExists(int id)
        {
            return _context.ProductoTecnologicos.Any(e => e.Id == id);
        }
    }
}
