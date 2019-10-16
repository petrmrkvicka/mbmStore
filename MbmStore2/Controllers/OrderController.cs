using Microsoft.AspNetCore.Mvc;
using MbmStore2.Models.ViewModels;

namespace MbmStore2.Controllers
{
    public class OrderController : Controller
    {
        private Cart cart;

        public OrderController(Cart cartService)
        {
            cart = cartService;
        }

        public ViewResult Checkout()
        {
            return View(new Order());
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if(cart.Lines.Count == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if(ModelState.IsValid)
            {
                cart.Clear();
                return View("Completed");
            } else
            {
                return View(order);
            }
        }
    }
}
