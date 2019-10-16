using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore2.Infrastructure;
using MbmStore2.Models;
using MbmStore2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Extensions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MbmStore2.Controllers
{
    public class CartController : Controller
    {
        private Cart cart;

        public CartController(Cart cartService)
        {
            cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart(int productID, string returnUrl, int quantity)
        {
            Product product = Repository.Products
            .FirstOrDefault(p => p.ProductId == productID);
            if (product != null)
            {
                cart.AddItem(product, quantity);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int productID, string returnUrl)
        {
            Product product = Repository.Products
            .FirstOrDefault(p => p.ProductId == productID);
            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }



    }
}
