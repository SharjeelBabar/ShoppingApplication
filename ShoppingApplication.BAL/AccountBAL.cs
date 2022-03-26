using ShoppingApplication.DAL;
using ShoppingApplication.Helper;
using ShoppingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.BAL
{
    public class AccountBAL
    {
        public void Register(User user)
        {
            user.JoinedOn = DateTime.UtcNow.AddHours(5);
            user.RoleId = 2;
            //user.AccessToken = new RandomGenerator().GenerateAccessToken();
            new AccountDAL().Register(user);
        }
        public User GetUserForLogin(string Email, string Password)
        {
            return new AccountDAL().GetUserForLogin(Email,Password);
        }
        //public User GetUserInfo(string AccessToken)
        //{
        //    return new AccountDAL().GetUserInfo(AccessToken);
        //}
        public bool CheckEmail(string email)
        {
            return new AccountDAL().CheckEmail(email);
        }
    }
}
