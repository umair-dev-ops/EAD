using System;
using System.Collections.Generic;
using System.Text;

namespace EAD_Project0.Shared
{
    public class Cart
    {
        public static List<int> Orders { get; set; } = new List<int>();
        public Customer Customer { get; set; } = new Customer();
        public bool hasPaid { get; set; } = false;

        public void Add(int productId)
        {
            Orders.Add(productId);
        }

        public void Remove(int position)
        {
            Orders.RemoveAt(position);
        }
        

    

    }
}
