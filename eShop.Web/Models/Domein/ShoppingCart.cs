using eShop.Web.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Web.Models.Domein
{
    public class ShoppingCart
    {

        public Guid Id { get; set; }

        public string OwnerId { get; set; }

        public eShopApplicationUser Owner { get; set; }

        public virtual ICollection<ProductInShoppingCart> ProductInShoppingCarts { get; set; }

    }
}
