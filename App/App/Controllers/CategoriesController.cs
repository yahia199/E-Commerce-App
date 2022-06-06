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

namespace App.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ShopDbContext _context;

        private readonly ICategory _catogry;

        public CategoriesController(ShopDbContext context, ICategory category)
        {
            _context = context;
            _catogry = category;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
            var category = await _catogry.GetCategories();
            return View(category);
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int id)
        {
            Category Category = await _catogry.GetCategory(id);

            return View(Category);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "Administrator")]

        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                await _catogry.Create(category);

                return Content("You have successfully added a category --> Name : " + category.Name);
            }
            return View(category);
        }

        // GET: Categories/Edit/5
        [Authorize(Policy = "Editor")]

        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Getcategory = await _catogry.GetCategory(id);
            if (Getcategory == null)
            {
                return NotFound();
            }
            return View(Getcategory);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {


                await _catogry.UpdateCategory(id, category);

                // return RedirectToAction(nameof(Index));
                return Content("You have successfully updated a product --> Name : " + category.Name);

            }
            return View(category);
        }

        // GET: Categories/Delete/5
        [Authorize(Policy = "Administrator")]

        public async Task<IActionResult> Delete(int id)
        {

            await _catogry.GetCategory(id);

            return View();
        }

        // POST: Categories/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            await _catogry.Delete(id);
            return RedirectToAction(nameof(Index));
        }

     
    }
}
