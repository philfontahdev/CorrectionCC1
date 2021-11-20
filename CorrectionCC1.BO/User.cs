using System.Collections.Generic;

namespace CorrectionCC1.BO
{
    public class User
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Fullname { get; set; }

        public List<Product> Products { get; set; }

        public User()
        {
            Products = new List<Product>();
        }

        public User(string email, string password, string fullname):this()
        {
            Email = email;
            Password = password;
            Fullname = fullname;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public List<Product> GetProducts()
        {
            var list = new List<Product>();
            foreach (var p in Products)
                list.Add(new Product(p));
            return list;
        }

        public User(User user):this(user?.Email, user?.Password, user?.Fullname)
        {

        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Email == user.Email;
        }

        public override int GetHashCode()
        {
            return -506688385 + EqualityComparer<string>.Default.GetHashCode(Email);
        }
    }
}
