using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LagkageHusWebApp.Models;
using LagkageHusWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LagkageHusWebApp.Pages
{
    public class ProductDetailsModel : PageModel
    {
        private readonly IProductService _productService;

        public ProductDetailsModel(IProductService productService)
        {
            _productService = productService;
        }

        public int Id { get; set; }
        public bool ProductFound { get => Product is not null; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public void OnGet(int id)
        {
            Id = id;
            Product = _productService.GetProducts().SingleOrDefault(p => p.Id == id);

            Amount = 1;
        }
    }
}
