using System.Linq;
using MbmStore2.Infrastructure;
using MbmStore2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MbmStore2.Controllers
{
    public class CatalogueController : Controller
    {
        public int PageSize = 4;

        // GET: /<controller>/
        public IActionResult Index(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel();
            model = new ProductsListViewModel
            {
                Products = Repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                    Repository.Products.Count() :
                        Repository.Products.Where(e =>
                        e.Category == category).Count()
                },

                CurrentCategory = category
            };

            return View(model);
        }
    }
}
