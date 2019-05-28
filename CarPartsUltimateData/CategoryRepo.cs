using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using CarPartsUltimateLib;

namespace CarPartsUltimateData
{
    public class CategoryRepo : ICategoryRepo
    {
        public CategoryRepo(string connectionString)
        {
            _connectionString = connectionString;
        }
        private string _connectionString {get; set;}

        public List<ICategory> GetCategories()
        {
            List<ICategory> categories = new List<ICategory>();
            using (SqlConnection conn = new SqlConnection())
            using (SqlCommand comm = new SqlCommand())
            {
                conn.ConnectionString = _connectionString;
                comm.Connection = conn;
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = "SELECT * FROM Categories";
                conn.Open();

                using (SqlDataReader results = comm.ExecuteReader())
                {
                    if(results.HasRows)
                    {
                        while(results.Read())
                        {
                            categories.Add(new Category
                            {
                                Name = results["Name"].ToString(),
                                Image = new Image
                                {
                                    ThumbnailSource = results["Image"].ToString()
                                },
                                DestinationHref = results["DestinationHref"].ToString()
                            });
                        }
                    }
                }
                conn.Close();
            }

            return categories;
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
