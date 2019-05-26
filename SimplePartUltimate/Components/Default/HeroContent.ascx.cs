using System;
using System.Web;
using System.Web.UI;
using CarPartsUltimateData;
using CarPartsUltimateLib;

namespace CarPartsUltimate.Components.Default
{

    public partial class HeroArea : BaseControl
    {
        public ContentArea ContentArea { get; set; }
        protected void Page_Load()
        {
            GetContentArea();
        }

        private void GetContentArea()
        {
            IContentAreaRepo contentAreaRepo = new ContentAreaRepo();
            ContentArea = contentAreaRepo.GetContentArea("HeroArea");
        }
    }
}
