using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;

namespace SWD62BEP.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;
        private readonly ICategoriesService _categoriesService;
        public ProductsController(IProductsService productsService, ICategoriesService categoriesService) {
            _productsService = productsService;
            _categoriesService = categoriesService;
        }
        public IActionResult Index()
        {
            var list = _productsService.GetProducts();
            return View(list);
        }
        public IActionResult Details(Guid id)
        {
            var p = _productsService.GetProduct(id);
            return View(p);
        }

        //the engine will load a page with empty fields
        [HttpGet]
        public IActionResult Create()
        {
            //fetch a list of categories 
            var listOfCategories = _categoriesService.GetCategories();
            //then we pass categories to the page to be loaded in the dropdown
            ViewBag.Categories = listOfCategories;

            return View();
        }


        //here details input by the user will be receieved
        [HttpPost]
        public IActionResult Create(ProductViewModel data)
        {
            try
            {
                _productsService.AddProduct(data);
                ViewData["feedback"] = "Product was added successfully";
            }
            catch(Exception ex)
            {
                ViewData["warning"] = "Product was not added";
            }
            var listOfCategories = _categoriesService.GetCategories();
            ViewBag.Categories = listOfCategories;
            return View(data);
        }
    }
}
