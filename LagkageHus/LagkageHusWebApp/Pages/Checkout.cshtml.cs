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
    public class CheckoutModel : PageModel
    {
        public void OnGet()
        {
        }

        public void SendOrder()
        {
            List<string> order = new List<string>();
            order.Add("TestProduct Something citronkage.jpg 10000000 Amount=5000");
            PostService.SendInformation(true, order);
        }
    }
}
