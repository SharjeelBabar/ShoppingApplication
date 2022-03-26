using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.Helper
{
    public class RandomGenerator
    {
        private static Random random = new Random();
        public string GenerateAccessToken()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string randomstring = new string(Enumerable.Repeat(chars, 32)
                .Select(x => x[random.Next(x.Length)]).ToArray());
            string ticks = DateTime.UtcNow.AddHours(5).Ticks.ToString();
            return randomstring + ticks;
        }
    }
}
