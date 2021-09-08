using LagkageHusWebApp.Models;
using System.Collections.Generic;

namespace LagkageHusWebApp.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}