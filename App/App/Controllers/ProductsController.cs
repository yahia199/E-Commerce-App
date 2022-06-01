using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Data;
using App.Models;
using App.Models.Interfaces;

namespace App.Controllers
{
    public class ProductsController : Controller
    {
       
        private readonly IProduct _product;

        private readonly ShopDbContext _context;
        

        public ProductsController(IProduct product, ShopDbContext context )
        {
            _product = product;
            _context = context;
        }


        // GET: Products
        public async Task<IActionResult> Index()
        {

            var products = await _product.GetProducts();
            return View(products);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _product.GetProduct(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {

                 await _product.Create(product);
            
                 return Content("You have successfully added a product --> Name : "+product.Name);
              

            }
           
            return View(product);
        }



       // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Getproduct = await _product.GetProduct(id);
        

            if (Getproduct == null)
            {
                return NotFound();
            }
           
            return View(Getproduct);
        }

        // POST: Products/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit( int id , Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var category = await _context.Category.FindAsync(id);
               
                   await _product.UpdateProduct( category, product);

                // return RedirectToAction(nameof(Index));
                return Content("You have successfully updated a product --> Name : " + product.Name);

            }

            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var product = await _context.Products
            //    .Include(p => p.Category)
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (product == null)
            //{
            //    return NotFound();
            //}

            return View();
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var product = await _context.Products.FindAsync(id);
            //_context.Products.Remove(product);
            //await _context.SaveChangesAsync();
            //Product product = await _product.GetProduct(id);

            await _product.Delete(id);
             return RedirectToAction(nameof(Index));
           // return Content("You have successfully deleted a product ");

        }

        //private bool ProductExists(int id)
        //{
        //    return _context.Products.Any(e => e.Id == id);
        //}
    }
}

