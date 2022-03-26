using ShoppingApplication.DAL;
using ShoppingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.BAL
{
    public class UserBAL
    {
        public List<User> GetSellers()
        {
            return new UserDAL().GetSellers();
        }
    }
}
