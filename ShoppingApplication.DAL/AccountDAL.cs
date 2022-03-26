using ShoppingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.DAL
{
    public class AccountDAL
    {
        private readonly ShoppingContext db = new ShoppingContext();
        public void Register(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
        public User GetUserForLogin(string Email, string Password)
        {
            return db.Users.Where(x => x.Email.Equals(Email, StringComparison.InvariantCultureIgnoreCase) && x.Password.Equals(Password)).FirstOrDefault();
        }
        //public User GetUserInfo(string AccessToken)
        //{
        //    return db.Users.Where(x => x.AccessToken.Equals(AccessToken)).FirstOrDefault();
        //}
        public bool CheckEmail(string email)
        {
            return db.Users.Where(x => x.Email.Equals(email, StringComparison.InvariantCultureIgnoreCase)).Any();
        }
    }
}
