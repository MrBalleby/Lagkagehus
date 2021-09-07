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
                new (){ Id = 1, Name="kagemand"},
                new Product(){ Id = 2, Name="jordbaer", Price=20},
                new Product(){ Id = 3, Name="cheesecake", Price=20},
                new Product(){ Id = 4, Name="citronkage", Price=20},
                new Product(){ Id = 5, Name="rumkugler", Price=20},
                new Product(){ Id = 6, Name="chokolade", Price=20}


            };


        }
    }
}
