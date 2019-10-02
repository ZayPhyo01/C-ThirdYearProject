using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class Cart
    {
        public string ClientId { get; set; }
        public int pid { get; set; }
        public string pname { get; set; }
        public int price { get; set; }
        public int qty { get; set; }
        public int amount { get; set; }
        public DateTime dtime { get; set; }

        public bool IsIncart { get; set; }
    }
}