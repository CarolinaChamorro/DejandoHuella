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
    public class ProductoElectrodomesticosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public ProductoElectrodomesticosController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        // GET: ProductoElectrodomesticos
        public async Task<IActionResult> Index()
        {
            var productoElectrodomestico = await _context.ProductoElectrodomesticos.ToListAsync();
            return View(productoElectrodomestico);
        }

        // GET: ProductoElectrodomesticos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoElectrodomestico = await _context.ProductoElectrodomesticos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productoElectrodomestico == null)
            {
                return NotFound();
            }

            return View(productoElectrodomestico);
        }

        // GET: ProductoElectrodomesticos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductoElectrodomesticos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductoElectrodomesticoViewModel productoElectrodomesticoViewModel)
        {
            if (ModelState.IsValid)
            {
                string unicoArchivo = UploadedFile(productoElectrodomesticoViewModel);
                ProductoElectrodomestico productoElectrodomestico = new ProductoElectrodomestico
                {
                    NombreProducto = productoElectrodomesticoViewModel.NombreProducto,
                    Marca = productoElectrodomesticoViewModel.Marca,
                    Modelo = productoElectrodomesticoViewModel.Modelo,
                    Costo = productoElectrodomesticoViewModel.Costo,
                    Medidas = productoElectrodomesticoViewModel.Medidas,
                    ConsumoElectrico=productoElectrodomesticoViewModel.ConsumoElectrico,
                    FotoBase64=unicoArchivo,
                };
                _context.Add(productoElectrodomestico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        private string UploadedFile(ProductoElectrodomesticoViewModel productoElectrodomesticoViewModel)
        {
            string unicoArchivo = null;

            if (productoElectrodomesticoViewModel.FotoBase64!= null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/ProductoElectrodomestico");
                unicoArchivo = Guid.NewGuid().ToString() + "_" + productoElectrodomesticoViewModel.FotoBase64.FileName;
                string filePath = Path.Combine(uploadsFolder, unicoArchivo);
                var fileStream = new FileStream(filePath, FileMode.Create);
                productoElectrodomesticoViewModel.FotoBase64.CopyTo(fileStream);

            }
            return unicoArchivo;
        }

        // GET: ProductoElectrodomesticos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoElectrodomestico = await _context.ProductoElectrodomesticos.FindAsync(id);
            if (productoElectrodomestico == null)
            {
                return NotFound();
            }
            return View(productoElectrodomestico);
        }

        // POST: ProductoElectrodomesticos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ConsumoElectrico,IdBodega,FotoBase64,NombreProducto,Marca,Modelo,Costo,Medidas")] ProductoElectrodomestico productoElectrodomestico)
        {
            if (id != productoElectrodomestico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productoElectrodomestico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoElectrodomesticoExists(productoElectrodomestico.Id))
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
            return View(productoElectrodomestico);
        }

        // GET: ProductoElectrodomesticos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoElectrodomestico = await _context.ProductoElectrodomesticos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productoElectrodomestico == null)
            {
                return NotFound();
            }

            return View(productoElectrodomestico);
        }

        // POST: ProductoElectrodomesticos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productoElectrodomestico = await _context.ProductoElectrodomesticos.FindAsync(id);
            _context.ProductoElectrodomesticos.Remove(productoElectrodomestico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoElectrodomesticoExists(int id)
        {
            return _context.ProductoElectrodomesticos.Any(e => e.Id == id);
        }
    }
}
