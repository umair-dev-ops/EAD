using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EAD_Project.Shared
{
    public enum Category
    {
        Sport,
        Cloth,
        Furniture
    }
    public class Product
    {
       
        [JsonConstructor]
        public Product()
        {
                
        }
        public Product(int id,string name,decimal price,Category category)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

    }

}
