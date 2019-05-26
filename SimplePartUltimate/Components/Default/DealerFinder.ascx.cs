using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using CarPartsUltimateData;
using CarPartsUltimateLib;

namespace CarPartsUltimate.Components.Default
{

    public partial class DealerFinder : BaseControl
    {
        public List<IDealership> Dealerships { get; set; }
        protected void Page_Load()
        {
            GetDealerships();
        }

        private void GetDealerships()
        {
            IDealershipRepo dealershipRepo = new DealershipRepo();
            Dealerships = dealershipRepo.GetNearestDealerships();
        }
    }
}
