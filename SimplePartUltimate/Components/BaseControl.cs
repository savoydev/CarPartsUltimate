using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using CarPartsUltimateLib.SiteConfig;

namespace CarPartsUltimate.Components
{
    public class BaseControl : System.Web.UI.UserControl
    {
        public List<SiteControl> GetControlsForPage(string pageName, int siteId = 0, bool IsB2B = false, bool IsWholesale = false)
        {
            List<SiteControl> controls = new List<SiteControl>();
            return DummyGetHeaderControls(siteId);
        }

        public void LoadControls(string pageName, string placeholderId, int siteId = 0, bool isB2B = false, bool isWholesale = false)
        {
            List<SiteControl> controls = GetControlsForPage(pageName, siteId, isB2B, isWholesale);
            controls.ForEach(control => AddControlToPlaceholder(LoadControlUp(control), placeholderId));
        }

        public BaseControl LoadControlUp(SiteControl siteControl)
        {
            return (BaseControl)LoadControl(siteControl.Path);
        }

        public void AddControlToPlaceholder(BaseControl baseControl, string placeholderId)
        {
            PlaceHolder placeholder = (PlaceHolder)FindControl(placeholderId);
            placeholder.Controls.Add(baseControl);
        }

        private List<SiteControl> DummyGetHeaderControls(int siteId)
        {
            switch (siteId)
            {
                case 0:
                    return ControlsForHeader0();
                default:
                    return ControlsForHeader0();
            }
        }

        private List<SiteControl> ControlsForHeader0()
        {
            return new List<SiteControl>
            {
                new SiteControl()
                {
                    Name = "PartsCategories",
                    Path = "~/Components/Header/PartsCategories.ascx"

                },
                new SiteControl()
                {
                    Name = "VehicleSelection",
                    Path = "~/Components/Header/VehicleSelection.ascx"

                }
            };
        }

        private List<SiteControl> ControlsForHeader1()
        {
            throw new NotImplementedException();
        }

        private List<SiteControl> ControlsForHeader2()
        {
            throw new NotImplementedException();
        }

    }
}
