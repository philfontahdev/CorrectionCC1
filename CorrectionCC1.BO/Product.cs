using System.Collections.Generic;

namespace CorrectionCC1.BO
{
    public class Product
    {
        public string Reference { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string reference, string name, double price)
        {
            Reference = reference;
            Name = name;
            Price = price;
        }

        public Product(Product product):this(product?.Reference, product?.Name, product?.Price ?? 0)
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Reference == product.Reference;
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Reference);
        }
    }
}
