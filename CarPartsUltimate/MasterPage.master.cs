using System;
using System.Web;
using System.Web.UI;
using CarPartsUltimate.Components.Header;

namespace CarPartsUltimate
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load()
        {
            HeaderNavigation.Controls.Add((HeaderContainer)LoadControl("~/Controls/Header/HeaderContainer.ascx"));
        }
    }
}
