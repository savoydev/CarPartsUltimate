using System;
using System.Collections.Generic;
using CarPartsUltimateLib;

namespace CarPartsUltimateData
{
    public class CategoryRepo : ICategoryRepo
    {
        public List<ICategory> GetCategories()
        {
            return GetDummyCategories();
        }

        private List<ICategory> GetDummyCategories()
        {
            List<ICategory> categories = new List<ICategory>();
            for (int i = 0; i < 16; i++)
            {
                categories.Add(new Category()
                {
                    Name = "Batteries",
                    Image = new Image()
                    {
                        ThumbnailSource = "https://image.flaticon.com/icons/svg/1670/1670683.svg",
                        FullsizeSource = "https://image.flaticon.com/icons/svg/1670/1670683.svg"
                    },
                    DestinationHref = "https://www.google.com"
                });
            }

            return categories;
        }
    }
}
