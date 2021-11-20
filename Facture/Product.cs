using System.Collections.Generic;

namespace Facture
{
    public class Product
    {
        public int Reference { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Total { get { return string.Format("(0)$", Price * Quantity); } }

        public Product()
        {

        }

        public Product(int reference, string name, double price, int quantity)
        {
            Reference = reference;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Product(Product product):this(product?.Reference?? 0, product?.Name, product?.Price ?? 0,product?.Quantity ?? 0)
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Reference == product.Reference;
        }

        public override int GetHashCode()
        {
            return -1304721846 + Reference.GetHashCode();
        }
    }
}
