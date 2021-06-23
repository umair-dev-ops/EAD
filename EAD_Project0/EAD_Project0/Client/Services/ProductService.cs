using EAD_Project0.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace EAD_Project0.Client.Services
{
    public class ProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
            => this.httpClient = httpClient;

        public async Task<Catalog> GetCatalog()
        {
            Product[] products = await this.httpClient.GetFromJsonAsync<Product[]>
                ("api/product");
            return new Catalog { Products = products.ToList() };
        }
    }
}
