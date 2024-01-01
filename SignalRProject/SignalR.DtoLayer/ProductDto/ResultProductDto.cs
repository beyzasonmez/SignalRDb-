﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.ProductDto
{
    public class ResultProductDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; } //Açıklama 
        public decimal Price { get; set; } //Fiyat 
        public string ImageUrl { get; set; } //Görsel
        public bool ProductStatus { get; set; } 
    }
}
