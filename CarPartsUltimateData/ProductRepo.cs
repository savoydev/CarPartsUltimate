using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CarPartsUltimateLib;

namespace CarPartsUltimateData
{
    public class ProductRepo : IProductRepo
    {
        public ProductRepo(string connectionString)
        {
            _connString = connectionString;
        }
        private string _connString { get; set; }

        public IEnumerable<IProduct> GetFeaturedProducts()
        {
            List<IProduct> products = new List<IProduct>();
            using (SqlConnection conn = new SqlConnection())
            using (SqlCommand comm = new SqlCommand())
            {
                conn.ConnectionString = _connString;
                comm.Connection = conn;
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = "SELECT * FROM Products";
                conn.Open();

                using (SqlDataReader results = comm.ExecuteReader())
                {
                    if(results.HasRows)
                    {
                        while(results.Read())
                        {
                            products.Add(new Product
                            {
                                StockCode = results["StockCode"].ToString(),
                                Title = results["Title"].ToString(),
                                Description = results["Description"].ToString(),
                                Images = new List<Image>()
                                {
                                    new Image
                                    {
                                        ThumbnailSource = results["Image"].ToString(),
                                        FullsizeSource = results["Image"].ToString()

                                    }
                                },
                                Price = Double.Parse(results["Price"].ToString()),
                                Enabled = bool.Parse(results["Enabled"].ToString()),
                                CategoryId = int.Parse(results["CategoryId"].ToString())
                            });
                        }
                    }
                }
            }

            return products;
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
