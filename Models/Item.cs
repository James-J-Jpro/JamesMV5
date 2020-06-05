using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JamesScioMVC5.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public int ItemQtyInStock { get; set; }
    }

    public class ItemBuyViewModel
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string UserName { get; set; }
    }
}