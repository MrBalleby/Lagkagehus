using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LagkageHusWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LagkageHusWebApp.Pages
{
    public class ShoppingCartModel : PageModel
    {
        public List<OrderItem> Orders { get; set; }
        public void OnGet()
        {
            Orders = new List<OrderItem>
            {
                new OrderItem
                {
                    Product = new Product 
                    { 
                        Name = "Citronm�ne", 
                        Description = "Citron kage, formet som et m�ne",
                        Image = "https://thumbs.dreamstime.com/z/giant-cake-display-hotel-brunch-giant-cake-display-hotel-brunch-doha-qater-142190130.jpg",
                        Price = 3.5
                    },
                    Amount = 1
                },
                new OrderItem
                {
                    Product = new Product
                    {
                        Name = "Bananbr�d",
                        Description = "Kage med banan",
                        Image = "https://thumbs.dreamstime.com/z/giant-cake-display-hotel-brunch-giant-cake-display-hotel-brunch-doha-qater-142190130.jpg",
                        Price = 3.5
                    },
                    Amount = 3
                }
            };
        }
    }
}
