using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace EAD_Project0.Shared
{
    public enum Category
    {
        Sport,
        Cloth,
        Furniture,
        Electronics,
        Health_Beauty,
        Toys,
        Groceries,
        Lifestyle,
        Fashion,
        Watches,
        Sports,
        Automotive
    }
    public class Product
    {
       
        [Newtonsoft.Json.JsonConstructor]
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
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Name is required")]
        
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Name is required")]
        
        public Category Category { get; set; }

    }

}
