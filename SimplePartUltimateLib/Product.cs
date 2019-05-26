using System;
using System.Collections.Generic;

namespace CarPartsUltimateLib
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string StockCode { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public List<Image> Images { get; set; }
        public bool Enabled { get; set; }
        public Product()
        {
        }
    }
}
