using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LagkageHusWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LagkageHusWebApp.Pages
{
    public class checkoutcompleteModel : PageModel
    {
        public void OnGet()
        {
        }
        public void SendConfirmation()
        {
            List<string> order = new List<string>();
            order.Add("Ordre modtaget - brug kode [#8]");
            PostService.SendInformation(false, order);
        }
    }
}
