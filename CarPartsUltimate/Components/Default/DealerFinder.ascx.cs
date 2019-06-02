using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web;
using System.Web.UI;
using CarPartsUltimateData;
using CarPartsUltimateLib;

namespace CarPartsUltimate.Components.Default
{

    public partial class DealerFinder : BaseControl
    {
        public List<IDealership> Dealerships { get; set; }
        private string _connString = ConfigurationManager.ConnectionStrings["masterConnection"].ToString();

        protected void Page_Load()
        {
            GetDealerships();
        }

        private void GetDealerships()
        {
            IDealershipRepo dealershipRepo = new DealershipRepo(_connString);
            Dealerships = dealershipRepo.GetNearestDealerships();
        }
    }
}
