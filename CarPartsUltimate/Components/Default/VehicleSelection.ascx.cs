using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using CarPartsUltimateData;
using CarPartsUltimateLib;

namespace CarPartsUltimate.Components.Default
{

    public partial class VehicleSelection : BaseControl
    {
        public List<RefineFitmentLink> RefineLinks { get; set; }
        protected void Page_Load()
        {
            GetRefineLinks();
        }

        private void GetRefineLinks()
        {
            FitmentRepo fitmentRepo = new FitmentRepo();
            RefineLinks = fitmentRepo.GetRefineLinks();
        }
    }
}
