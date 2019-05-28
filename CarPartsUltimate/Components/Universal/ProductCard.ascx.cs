using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using CarPartsUltimateLib;

namespace CarPartsUltimate.Components.Universal
{

    public partial class ProductCard : BaseControl
    {
        public IProduct Product { get; set; }

        public string GetFirstImage(IProduct product)
        {
            return product.Images.FirstOrDefault().ThumbnailSource;
        }
    }
}
