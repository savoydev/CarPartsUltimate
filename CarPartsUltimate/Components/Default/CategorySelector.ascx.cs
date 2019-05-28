using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web;
using System.Web.UI;
using CarPartsUltimateData;
using CarPartsUltimateLib;

namespace CarPartsUltimate.Components.Default
{

    public partial class CategorySelector : BaseControl
    {
        public List<ICategory> Categories { get; set; }
        private string _connString = ConfigurationManager.ConnectionStrings["masterConnection"].ToString();
        protected void Page_Load()
        {
            GetCategories();
        }

        private void GetCategories()
        {
            ICategoryRepo categoryRepo = new CategoryRepo(_connString);
            Categories = categoryRepo.GetCategories();
        }
    }
}
