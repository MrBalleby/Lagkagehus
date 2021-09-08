using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LagkageHusWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LagkageHusWebApp.Pages
{
    public class shoppageModel : PageModel
    {
        public void OnGet()
        {

            var products = new List<Product>() {
                new (){ Name="kagemand"},
                new Product(){ Name="jordbaer", Price=20},
                new Product(){ Name="cheesecake", Price=20},
                new Product(){ Name="citronkage", Price=20},
                new Product(){ Name="rumkugler", Price=20},
                new Product(){ Name="chokolade", Price=20}


            };


        }
    }
}
