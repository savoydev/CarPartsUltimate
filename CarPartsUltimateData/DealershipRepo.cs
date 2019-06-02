using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using CarPartsUltimateLib;

namespace CarPartsUltimateData
{
    public class DealershipRepo : IDealershipRepo
    {
        private string ConnectionString { get; set; }

        public DealershipRepo(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<IDealership> GetNearestDealerships()
        {
            List<IDealership> dealerships = new List<IDealership>();

            using (SqlConnection conn = new SqlConnection())
            using (SqlCommand comm = new SqlCommand())
            {
                conn.ConnectionString = ConnectionString;
                comm.Connection = conn;
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = "SELECT * FROM Dealerships";
                conn.Open();
                using (SqlDataReader results = comm.ExecuteReader())
                {
                    if(results.HasRows)
                    {
                        while(results.Read())
                        {
                            dealerships.Add(new Dealership { 
                                Name = results["Name"].ToString(),
                                StreetAddress = results["StreetAddress"].ToString(),
                                CityAddress = results["CityAddress"].ToString(),
                                StateAddress = results["StateAddress"].ToString(),
                                ZipCodeAddress = results["ZipCodeAddress"].ToString(),
                                CountryAddress = results["CountryAddress"].ToString(),
                                PhoneNumber = results["PhoneNumber"].ToString(),
                                Enabled = bool.Parse(results["Enabled"].ToString())
                            });
                        }
                    }
                }
            }
            return dealerships.Take(3).ToList();
        }

        private List<IDealership> DummmyDealer3()
        {
            return new List<IDealership>
            {
                new Dealership
                {
                Name = "Marietta Toyota",
                PartsSiteUrl = "https://www.google.com"
                },
                new Dealership
                {
                Name = "Toyota South Atlanta",
                PartsSiteUrl = "https://www.google.com"
                },
                new Dealership
                {
                Name = "Jim Ellis Toyota of McDonough",
                PartsSiteUrl = "https://www.google.com"
                } 
            };
        }
    }
}
