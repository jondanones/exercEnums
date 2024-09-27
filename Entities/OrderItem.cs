using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercEnums.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal() => Quantity * Product.Price;
        public override string ToString() => Product.Name + ", $" + Product.Price + ", Quantity: " + Quantity + ", Subtotal: " + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
    }
}
