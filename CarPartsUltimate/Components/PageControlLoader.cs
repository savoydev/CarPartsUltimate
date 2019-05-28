using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarPartsUltimateData;
using CarPartsUltimateLib.SiteConfig;

namespace CarPartsUltimate.Components
{
    public class CarPartsPage : Page
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["masterConnection"].ConnectionString;

        public void LoadControls(string pageName, string placeholderId, int siteId = 0, bool isB2B = false, bool isWholesale = false)
        {

            IControlsRepo controlsRepo = new ControlsRepo(connString);
            List<SiteControl> controls = controlsRepo.GetControlsForPage(siteId, pageName);
            controls.Add(new SiteControl
            {
                Name = "VehicleSelectionModal.ascx",
                Path = "~/Components/Header/VehicleSelectionModal.ascx"
            });

            controls.ForEach(control => AddControlToPlaceholder(LoadControlUp(control), placeholderId));
        }

        public BaseControl LoadControlUp(SiteControl siteControl)
        {
            BaseControl baseControl = (BaseControl)LoadControl(siteControl.Path);
            baseControl.ControlId = siteControl.Name;
            baseControl.ControlOrder = siteControl.Order;
            return baseControl;
        }

        public void AddControlToPlaceholder(BaseControl baseControl, string placeholderId)
        {
            PlaceHolder placeholder = (PlaceHolder)FindControl(placeholderId);
            placeholder.Controls.Add(baseControl);
        }

        public List<SiteControl> GetControlsForPage(string pageName, int siteId = 0, bool IsB2B = false, bool IsWholesale = false)
        {
            List<SiteControl> controls = new List<SiteControl>();

            switch (pageName)
            {
                case "default":
                    return DummyGetControlsForDefaultPage(siteId);
                default:
                    return new List<SiteControl>();

            }
        }

        private List<SiteControl> DummyGetControlsForDefaultPage(int siteId)
        {
            switch(siteId)
            {
                case 0:
                    return ControlsFor0();
                case 1:
                    return ControlsFor1();
                case 2:
                    return ControlsFor2();
                case 3:
                    return ControlsFor3();
                default:
                    return ControlsFor0();
            }

        }

        private List<SiteControl> ControlsFor0()
        {
            return new List<SiteControl>
            {
                new SiteControl()
                {
                    Name = "HeroContent",
                    Path = "~/Controls/Default/HeroContent.ascx"
                },
                new SiteControl()
                {
                    Name = "DealerFinder",
                    Path = "~/Controls/Default/DealerFinder.ascx"
                },
                new SiteControl()
                {
                    Name = "VehicleSelection",
                    Path = "~/Controls/Default/VehicleSelection.ascx"
                },
                new SiteControl()
                {
                    Name = "CategorySelector",
                    Path = "~/Controls/Default/CategorySelector.ascx"
                },
                 new SiteControl()
                {
                    Name = "FeaturedProducts",
                    Path = "~/Controls/Default/FeaturedProducts.ascx"
                },
                new SiteControl()
                {
                    Name = "VehicleSelectionModal",
                    Path = "~/Controls/Header/VehicleSelectionModal.ascx"
                }
            };
        }

        private List<SiteControl> ControlsFor1()
        {
            return new List<SiteControl>
            {
                new SiteControl()
                {
                    Name = "HeroContent",
                    Path = "~/Controls/Default/HeroContent.ascx"
                },
                new SiteControl()
                {
                    Name = "DealerFinder",
                    Path = "~/Controls/Default/DealerFinder.ascx"
                },
                 new SiteControl()
                {
                    Name = "FeaturedProducts",
                    Path = "~/Controls/Default/FeaturedProducts.ascx"
                },
                new SiteControl()
                {
                    Name = "VehicleSelection",
                    Path = "~/Controls/Default/VehicleSelection.ascx"
                },
                new SiteControl()
                {
                    Name = "CategorySelector",
                    Path = "~/Controls/Default/CategorySelector.ascx"
                }

            };
        }

        private List<SiteControl> ControlsFor2()
        {
            return new List<SiteControl>
            {
                new SiteControl()
                {
                    Name = "HeroContent",
                    Path = "~/Controls/Default/HeroContent.ascx"
                },
                new SiteControl()
                {
                    Name = "VehicleSelection",
                    Path = "~/Controls/Default/VehicleSelection.ascx"
                },
                new SiteControl()
                {
                    Name = "CategorySelector",
                    Path = "~/Controls/Default/CategorySelector.ascx"
                },
                 new SiteControl()
                {
                    Name = "FeaturedProducts",
                    Path = "~/Controls/Default/FeaturedProducts.ascx"
                }
            };
        }

        private List<SiteControl> ControlsFor3()
        {
            return new List<SiteControl>
            {
                new SiteControl()
                {
                    Name = "HeroContent",
                    Path = "~/Controls/Default/HeroContent.ascx"
                },
                new SiteControl()
                {
                    Name = "DealerFinder",
                    Path = "~/Controls/Default/DealerFinder.ascx"
                },
                new SiteControl()
                {
                    Name = "VehicleSelection",
                    Path = "~/Controls/Default/VehicleSelection.ascx"
                },
                new SiteControl()
                {
                    Name = "CategorySelector",
                    Path = "~/Controls/Default/CategorySelector.ascx"
                }
            };
        }
    }
}
