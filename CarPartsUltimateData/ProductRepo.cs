using System;
using System.Collections.Generic;
using CarPartsUltimateLib;

namespace CarPartsUltimateData
{
    public class ProductRepo : IProductRepo
    {
        public List<Product> GetFeaturedProducts()
        {
            return GetDummyProducts();
        }

        private List<Product> GetDummyProducts()
        {
            List<Product> products = new List<Product>{
            new Product()
            {
                StockCode = "ASDA1213",
                Description = "This is a cool product",
                Title = "Cool Product",
                Price = 12.34,
                Enabled = true,
                Images = new List<Image>()
                {
                    new Image()
                    {
                        ThumbnailSource = "https://image.flaticon.com/icons/svg/1670/1670676.svg",
                        FullsizeSource = "https://image.flaticon.com/icons/svg/1670/1670676.svg"

                    }
                }
            }, new Product()
            {
                StockCode = "ASDA1213",
                Description = "This is a cool product",
                Title = "Best Product",
                Price = 56.78,
                Enabled = true,
                Images = new List<Image>()
                {
                    new Image()
                    {
                        ThumbnailSource = "https://image.flaticon.com/icons/svg/1670/1670676.svg",
                        FullsizeSource = "https://image.flaticon.com/icons/svg/1670/1670676.svg"

                    }
                }
            }, new Product()
            {
                StockCode = "ASDA1213",
                Description = "This is a cool product",
                Title = "Awesome Product",
                Price = 91.01,
                Enabled = true,
                Images = new List<Image>()
                {
                    new Image()
                    {
                        ThumbnailSource = "https://image.flaticon.com/icons/svg/1670/1670676.svg",
                        FullsizeSource = "https://image.flaticon.com/icons/svg/1670/1670676.svg"

                    }
                }
            }, new Product()
            {
                StockCode = "ASDA1213",
                Description = "This is a cool product",
                Title = "Cool Product",
                Price = 12.13,
                Enabled = true,
                Images = new List<Image>()
                {
                    new Image()
                    {
                        ThumbnailSource = "https://image.flaticon.com/icons/svg/1670/1670676.svg",
                        FullsizeSource = "https://image.flaticon.com/icons/svg/1670/1670676.svg"

                    }
                }
            },new Product()
            {
                StockCode = "ASDA1213",
                Description = "This is a cool product",
                Title = "Wow Product",
                Price = 14.15,
                Enabled = true,
                Images = new List<Image>()
                {
                    new Image()
                    {
                        ThumbnailSource = "https://image.flaticon.com/icons/svg/1670/1670676.svg",
                        FullsizeSource = "https://image.flaticon.com/icons/svg/1670/1670676.svg"

                    }
                }
            },new Product()
            {
                StockCode = "ASDA1213",
                Description = "This is a cool product",
                Title = "Cheap Product",
                Price = 16.17,
                Enabled = true,
                Images = new List<Image>()
                {
                    new Image()
                    {
                        ThumbnailSource = "https://image.flaticon.com/icons/svg/1670/1670676.svg",
                        FullsizeSource = "https://image.flaticon.com/icons/svg/1670/1670676.svg"

                    }
                }
            }
            };

            //List<Product> products = new List<Product>();
            return products;
        }
    }
}
