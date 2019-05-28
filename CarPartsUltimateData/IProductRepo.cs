using System.Collections.Generic;
using CarPartsUltimateLib;

namespace CarPartsUltimateData
{
    public interface IProductRepo
    {
        IEnumerable<IProduct> GetFeaturedProducts();
    }
}