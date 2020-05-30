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
        public DisplayProduct()
        {

        }
        public DisplayProduct(string name, double price, int quantityInCart)
        {
            Name = name;
            Price = price;
            QuantityInCart = quantityInCart;
        }
        public string Name { get; set; }

        public string CategoryName { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public int QuantityInCart { get; set; }

        public ProductType ProductTypeProperty { get; set; }

        public List<string> Allergens { get; set; }

        public string Category { get; set; }

    }
}
