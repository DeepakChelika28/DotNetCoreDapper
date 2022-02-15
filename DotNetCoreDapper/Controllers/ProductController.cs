using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreDapper.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductData _productData;
        public ProductController(IProductData productData)
        {
            _productData = productData;
        }
        public IActionResult Index()
        {
            var productsData = _productData.GetProducts();
            return View(productsData.Result);
        }

        public IActionResult Create()
        {
            var categoriesData = _productData.GetCategories();
            ViewBag.Categories = categoriesData.Result;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            ModelState.Remove("ProductId");
            ModelState.Remove("CategoryName");
            if (ModelState.IsValid)
            {
                _productData.InsertProduct(product);
                return RedirectToAction("Index");
            }
            else
            {
                var categoriesData = _productData.GetCategories();
                ViewBag.Categories = categoriesData.Result;
                return View();
            }
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Categories =  _productData.GetCategories().Result;
            Product? product = _productData.GetProductById(id).Result;
            return View("Create", product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ModelState.Remove("CategoryName");
            if (ModelState.IsValid)
            {
                _productData.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            else
            {
                var categoriesData = _productData.GetCategories();
                ViewBag.Categories = categoriesData.Result;
                return View("Create", product);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Product? product = _productData.GetProductById(id).Result;
            if (product != null)
            {
                _productData.DeleteProduct(id);
            }

            return RedirectToAction("Index");
        }
    }
}
