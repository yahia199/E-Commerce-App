using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using App.Models;
using App.Models.Dto;
using App.Models.Interfaces;
using App.Models.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class OrdersController : Controller
    {
        private readonly EmailService _emailService;
        private readonly IProduct _product;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrder _order;

        public OrdersController(IProduct product, ShoppingCart shoppingCart, IOrder order, EmailService emailService)
        {
            _product = product;
            _shoppingCart = shoppingCart;
            _order = order;
            _emailService = emailService;
        }
        public async Task<IActionResult> Index()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userRole = User.FindFirstValue(ClaimTypes.Role);
            var orders = await _order.GetOrdersByUserIdAndRoleAsync(userId, userRole);
            return View(orders);
        }
        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var response = new ShoppingCartDTO()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _product.GetProduct(id);
            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
        public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _product.GetProduct(id);
            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
        public async Task<IActionResult> CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userEmailAddress = User.FindFirstValue(ClaimTypes.Email);
            await _order.StoreOrderAsync(items, userId, userEmailAddress);
            await _shoppingCart.ClearShoppingCartAsync();
            string message = "Order Summary : <br/> ";

            foreach (ShoppingCartItem shopping in items)
            {
                message += $"you bought a  {shopping.product.Name}  for a price   {shopping.product.Price} <br/> ";
            }

            await _emailService.SendEmail(message, "22029818@student.ltuc.com", "Order Summary");
            await _emailService.SendEmail(message, "yahiakhlil0151400@gmail.com", "Order Summary");
            await _emailService.SendEmail(message, userEmailAddress, "Order Summary");

            return View();
        }


    }
}
