﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingApplication.Models
{
    public class AddressDetail
    {
        public int Id { get; set; }
        public string HouseNo { get; set; }
        public string StreetNo { get; set; }
        public string Area { get; set; }
        public virtual City City { get; set; }
        public int CityId { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}