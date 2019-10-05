using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevKSoft.Northwind.Business.Abstract;
using DevKSoft.Northwind.Entities.Concrete;
using DevKSoft.Northwind.MvcWebUI.Models;

namespace DevKSoft.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            var model = new ProductListModel
            {
                Products = _productService.GetList()
            };
            return View(model);
        }

        public string Add()
        {
            _productService.Add(new Product
            {
                CategoryId = 1,
                ProductName = "laptop",
                QuantityPerUnit = "2",
                UnitPrice = 200
            });
            return "Added";
        }
    }
}