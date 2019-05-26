using System.Collections.Generic;
using CarPartsUltimateLib.SiteConfig;

namespace CarPartsUltimateData
{
    public interface IControlsRepo
    {
        List<SiteControl> GetControlsForPage(int siteId, string pageName);
    }
}