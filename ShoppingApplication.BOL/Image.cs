using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingApplication.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}