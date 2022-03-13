using eShop.Web.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Web.Models.Domein
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public eShopApplicationUser User { get; set; }

        public virtual ICollection<ProductInOrder> ProductInOrders { get; set; }
    }
}
