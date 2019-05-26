using System;
using System.Web;
using System.Web.UI;

namespace CarPartsUltimate.Components.Header
{

    public partial class HeaderContainer : BaseControl
    {
        private const string _pageType = "header";
        public void Page_Load()
        {
            LoadControls(_pageType, "HeaderControlsPlaceholder", GetSiteId());
        }

        private int GetSiteId()
        {
            int result = 0;
            if (Request.QueryString["id"] != null)
            {
                int.TryParse(Request.QueryString["id"], out result);
            }
            return result;
        }
    }
}
