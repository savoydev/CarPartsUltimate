using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using CarPartsUltimate.Components;
using CarPartsUltimate.Components.Header;
using System.Configuration;
using CarPartsUltimateData;
using CarPartsUltimateLib.SiteConfig;

namespace CarPartsUltimate
{

    public partial class Default : CarPartsPage
    {
        private const string _pageType = "default";
        public void Page_Load()
        {
            LoadHeaderControls();
            LoadControls(_pageType, "DefaultControls", GetSiteId());
        }

        private void LoadHeaderControls()
        {
            HeaderNavigation.Controls.Add((HeaderContainer)LoadControl("~/Components/Header/HeaderContainer.ascx"));
        }

        private int GetSiteId()
        {
            int result = 0;
            if (Request.QueryString["id"] != null)
            {
                int.TryParse(Request.QueryString["id"], out result);
            }
            return result == 0 ? 1 : result;
        }
    }
}
