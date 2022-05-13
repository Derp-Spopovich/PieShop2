using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        public Pie Pie { get; set; }

        public int Amount { get; set; }
        //imagine this is a session ShoppingCartId
        public string ShoppingCartId { get; set; }
    }
}
