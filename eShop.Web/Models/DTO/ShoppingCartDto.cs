using eShop.Web.Models.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Web.Models.DTO
{
    public class ShoppingCartDto
    {

        public List<ProductInShoppingCart> Products { get; set; }


        public double TotalPrice { get; set; }
    }
}
