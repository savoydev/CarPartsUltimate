using System;
using CarPartsUltimateLib;

namespace CarPartsUltimateData
{
    public class ContentAreaRepo : IContentAreaRepo
    {
        public ContentArea GetContentArea(string areaName)
        {
            return GetDummyContentArea(areaName);
        }

        private static ContentArea GetDummyContentArea(string areaName)
        {
            return new ContentArea()
            {
                Title = "Keep it real. Keep it Toyota.",
                Text = "Shop Toyota USA's dealer network for Genuine Toyota Parts & Accessories"
            };
        }
    }
}
