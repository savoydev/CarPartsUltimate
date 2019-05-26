using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using CarPartsUltimateLib;

namespace CarPartsUltimate.Components.Universal
{

    public partial class ProductCard : BaseControl
    {
        public Product Product { get; set; }

        public string GetFirstImage(Product product)
        {
            return product.Images.FirstOrDefault().ThumbnailSource;
        }
    }
}
