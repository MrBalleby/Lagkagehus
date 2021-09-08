using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LagkageHusWebApp.Models;
using Newtonsoft.Json;

namespace LagkageHusWebApp.Services
{
    public class JsonProductService : IProductService
    {
        private readonly ProductList _jsonObject;
        public JsonProductService()
        {
            var json = File.ReadAllText("products.json", Encoding.UTF8);

            _jsonObject = JsonConvert.DeserializeObject<ProductList>(json);
        }

        public List<Product> GetProducts()
        {
            return _jsonObject.Products;
        }
    }

    /// <summary>
    /// Used for newtonsoft desirialization
    /// </summary>
    class ProductList
    {
        public List<Product> Products { get; set; }
    }
}
