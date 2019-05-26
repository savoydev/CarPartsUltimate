using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using CarPartsUltimateData;
using CarPartsUltimateLib;
using System.Linq;
using CarPartsUltimate.Components.Universal;

namespace CarPartsUltimate.Components.Default
{

    public partial class FeaturedProducts : BaseControl
    {
        protected void Page_Load()
        {
            LoadProductCards();
        }

        private void LoadProductCards()
        {
            List<Product> products = GetProducts();
            if(products.Any())
            {
                products.ForEach(p => LoadProductCardComponent(p));
            }
            else
            {
                FeaturedProductsComponent.Visible = false;
            }
        }

        private void LoadProductCardComponent(Product product)
        {
            ProductCard productCard = (ProductCard)LoadControl("~/Components/Universal/ProductCard.ascx");
            productCard.Product = product;
            ProductCardPlaceholder.Controls.Add(productCard);
        }

        private List<Product> GetProducts()
        {
            ProductRepo productRepo = new ProductRepo();
            return productRepo.GetFeaturedProducts();
        }
    }
}
