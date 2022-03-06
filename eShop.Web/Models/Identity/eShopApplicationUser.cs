using eShop.Web.Models.Domein;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Web.Models.Identity
{
    public class eShopApplicationUser : IdentityUser
    {
        public int FirstName { get; set; }

        public int LastName { get; set; }
 
        public int Address { get; set; }

        public virtual ShoppingCart UserCart { get; set; }

    }
}
