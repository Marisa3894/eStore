﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eStore.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        public string Filling { get; set; }

        public string Fabric { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public decimal WPrice { get; set; }

        public string Description { get; set; }

        public DateTime InventoryDate { get; set; }

    }
}