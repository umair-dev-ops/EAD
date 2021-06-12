using System;
using System.Collections.Generic;
using System.Text;

namespace EAD_Project.Shared
{
    public class Cart
    {
        public List<int> Orders { get; set; } = new List<int>();
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
