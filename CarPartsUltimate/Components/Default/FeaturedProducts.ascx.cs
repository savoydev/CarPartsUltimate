using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using CarPartsUltimateData;
using CarPartsUltimateLib;
using System.Linq;
using CarPartsUltimate.Components.Universal;
using System.Configuration;

namespace CarPartsUltimate.Components.Default
{

    public partial class FeaturedProducts : BaseControl
    {
        public bool HasProducts = true;
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["masterConnection"].ToString();

        protected void Page_Load()
        {
            LoadProductCards();
        }

        private void LoadProductCards()
        {
            List<IProduct> products = GetProducts();
            if(products.Any())
            {
                products.ForEach(p => LoadProductCardComponent(p));
            }
            else
            {
                HasProducts = false;
            }
        }

        private void LoadProductCardComponent(IProduct product)
        {
            ProductCard productCard = (ProductCard)LoadControl("~/Components/Universal/ProductCard.ascx");
            productCard.Product = product;
            ProductCardPlaceholder.Controls.Add(productCard);
        }

        private List<IProduct> GetProducts()
        {
            IProductRepo productRepo = new ProductRepo(_connectionString);
            return productRepo.GetFeaturedProducts().Take(5).ToList();
        }
    }
}
