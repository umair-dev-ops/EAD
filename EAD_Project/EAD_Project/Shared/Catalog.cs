using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EAD_Project.Shared
{
    public class Catalog
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public Product GetProduct(int id) =>
            Products.SingleOrDefault(p => p.Id == id);
    }
}
