using System.Collections.Generic;
using CarPartsUltimateLib;

namespace CarPartsUltimateData
{
    public interface IDealershipRepo
    {
        List<IDealership> GetNearestDealerships();
    }
}