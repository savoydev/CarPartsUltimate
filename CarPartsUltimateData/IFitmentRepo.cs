using System.Collections.Generic;
using CarPartsUltimateLib;

namespace CarPartsUltimateData
{
    public interface IFitmentRepo
    {
        List<RefineFitmentLink> GetRefineLinks();
    }
}