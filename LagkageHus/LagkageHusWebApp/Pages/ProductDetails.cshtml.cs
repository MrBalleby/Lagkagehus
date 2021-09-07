using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LagkageHusWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LagkageHusWebApp.Pages
{
    public class ProductDetailsModel : PageModel
    {
        public Product Product { get; set; }
        public int Amount { get; set; }
        public void OnGet()
        {
            Product = new Product
            {
                Name = "Kæmpe fucking kage",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Price = 3.5,
                Image = "https://thumbs.dreamstime.com/z/giant-cake-display-hotel-brunch-giant-cake-display-hotel-brunch-doha-qater-142190130.jpg"
            };
            Amount = 1;
        }
    }
}
