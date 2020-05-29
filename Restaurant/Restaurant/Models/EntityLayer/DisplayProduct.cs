using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models.EntityLayer
{
    public enum ProductType
    {
        Product,
        Menu
    }
    public class DisplayProduct
    {
        public string Name { get; set; }

        public string CategoryName { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public ProductType ProductTypeProperty { get; set; }

        public List<string> Allergens { get; set; }

    }
}
