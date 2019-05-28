using System.Collections.Generic;

namespace CarPartsUltimateLib
{
    public interface IProduct
    {
        int Id { get; set; }
        string StockCode { get; set; }
        string Description { get; set; }
        string Title { get; set; }
        double Price { get; set; }
        List<Image> Images { get; set; }
        bool Enabled { get; set; }
        int CategoryId { get; set; }
    }
}