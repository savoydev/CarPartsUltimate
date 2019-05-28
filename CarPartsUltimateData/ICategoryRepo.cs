using System.Collections.Generic;
using CarPartsUltimateLib;

namespace CarPartsUltimateData
{
    public interface ICategoryRepo
    {
        List<ICategory> GetCategories();
    }
}