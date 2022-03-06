﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Web.Models.Domein
{
    public class Product
    { 
        public Guid Id { get; set; }
        [Required]

        public string ProductName { get; set; }
        [Required]
        public string ProductImage { get; set; }
        [Required]

        public string ProductDescription { get; set; }
        [Required]

        public int Rating { get; set; }
        [Required]

        public virtual ICollection<ProductInShoppingCart> ProductInShoppingCarts { get; set; }

    }
}