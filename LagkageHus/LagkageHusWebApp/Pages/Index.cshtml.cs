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
    public class shoppageModel : PageModel
    {
        public shoppageModel(IProductService productService)
        {
            Products = productService.GetProducts();
        }

        public List<Product> Products { get; set; }

        public void OnGet()
        {

        }
    }
}
