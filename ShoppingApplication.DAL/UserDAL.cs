using ShoppingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.DAL
{
    public class UserDAL
    {
        private readonly ShoppingContext db = new ShoppingContext();
        public List<User> GetSellers()
        {
            return db.Users.Where(x => x.RoleId == 2).ToList();
        }
    }
}
