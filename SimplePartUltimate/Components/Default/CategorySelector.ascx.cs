﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using CarPartsUltimateData;
using CarPartsUltimateLib;

namespace CarPartsUltimate.Components.Default
{

    public partial class CategorySelector : BaseControl
    {
        public List<ICategory> Categories { get; set; }
        protected void Page_Load()
        {
            GetCategories();
        }

        private void GetCategories()
        {
            ICategoryRepo categoryRepo = new CategoryRepo();
            Categories = categoryRepo.GetCategories();
        }
    }
}
