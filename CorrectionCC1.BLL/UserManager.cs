using CorrectionCC1.BO;
using CorrectionCC1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionCC1.BLL
{
    public class UserManager
    {
        private UserRepository userRepository;
        public UserManager()
        {
            userRepository = new UserRepository();
        }

        public void AddUser(User user)
        {
            userRepository.Add(user);
        }

        public void EditUser(User oldUser, User newUser)
        {
            userRepository.Set(oldUser, newUser);
        }

        public void DeleteUser(User user)
        {
            userRepository.Delete(user);
        }

        public List<User> GetAllUser()
        {
            return userRepository.GetAll();
        }

        public void AddUserProduct(User user, Product product)
        {
            if (userRepository.IndexOf(user) < 0)
                throw new KeyNotFoundException($"{nameof(User)} not found !");
            user.AddProduct(product);
            userRepository.Set(user, user);
        }

        public void RemoveUserProduct(User user, Product product)
        {
            if (userRepository.IndexOf(user) < 0)
                throw new KeyNotFoundException($"{nameof(User)} not found !");
            user.RemoveProduct(product);
            userRepository.Set(user, user);
        }

        public User Authenticate(string email, string password)
        {
            var users = userRepository.FindByEmail(email);
            foreach (var user in users)
                if (user.Email == email && user.Password == password)
                    return user;
            return null;
        }
    }
}
