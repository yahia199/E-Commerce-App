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
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Azure.Storage.Blobs;
using System.Configuration;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;

namespace App.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IConfiguration Configuration;

        private readonly IProduct _product;

        private readonly ShopDbContext _context;

        public ProductsController(IProduct product, ShopDbContext context, IConfiguration config)
        {
            _product = product;
            _context = context;
            Configuration = config;
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
            if (id == 0)
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
        [Authorize(Policy = "Administrator")]

        public IActionResult Create()
        {
            return View();
        }

      

        [HttpPost]
        public async Task<IActionResult> Create(Product product, IFormFile file)
        {
            BlobContainerClient container = new BlobContainerClient(Configuration.GetConnectionString("AzureBlob"), "folder");
            await container.CreateIfNotExistsAsync();
            BlobClient blob = container.GetBlobClient(file.FileName);
            using var stream = file.OpenReadStream();

            BlobUploadOptions options = new BlobUploadOptions()
            {
                HttpHeaders = new BlobHttpHeaders() { ContentType = file.ContentType }
            };


            if (!blob.Exists())
            {
                await blob.UploadAsync(stream, options);
            }
            product.ImageUrl = blob.Uri.ToString();

            if (ModelState.IsValid)
            {

                 await _product.Create(product);

                return RedirectToAction("Index");


            }
            stream.Close();

            return View(product);
        }



        // GET: Products/Edit/5
        [Authorize(Policy = "Editor")]

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
        public async Task<IActionResult> Edit( int id , Product product, IFormFile file)
        {
            BlobContainerClient container = new BlobContainerClient(Configuration.GetConnectionString("AzureBlob"), "folder");
            await container.CreateIfNotExistsAsync();
            BlobClient blob = container.GetBlobClient(file.FileName);
            using var stream = file.OpenReadStream();

            BlobUploadOptions options = new BlobUploadOptions()
            {
                HttpHeaders = new BlobHttpHeaders() { ContentType = file.ContentType }
            };


            if (!blob.Exists())
            {
                await blob.UploadAsync(stream, options);
            }
            product.ImageUrl = blob.Uri.ToString();
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var category = await _context.categories.FindAsync(id);
               
                   await _product.UpdateProduct( category, product);

                return RedirectToAction("Index");

            }
            stream.Close();

            return View(product);
        }

        // GET: Products/Delete/5
        [Authorize(Policy = "Administrator")]

        public async Task<IActionResult> Delete(int id)
        {
            await _product.GetProduct(id);

            return View();
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
         

            await _product.Delete(id);
             return RedirectToAction(nameof(Index));

        }

      
    }
}

