using System;
using System.Globalization;

namespace Enumeracao.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public Double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public Double subTotal()
        {
            return this.Quantity * this.Price;
        }

        public override string ToString()
        {
            return $"{this.Product.Name}, ${this.Price.ToString("F2",CultureInfo.InvariantCulture)}, Quantity: {this.Quantity}, Subtotal: ${subTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
