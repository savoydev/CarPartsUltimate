using System;
using System.Collections.Generic;
using CarPartsUltimateLib.SiteConfig;
using System.Data;
using System.Data.SqlClient;

namespace CarPartsUltimateData
{

    public class MSSQLControlsRepo : IControlsRepo
    {
        private string _connString { get; set; }

        public MSSQLControlsRepo(string connString = "")
        {
            _connString = connString;
        }

        public List<SiteControl> GetControlsForPage(int siteId, string pageName)
        {
            List<SiteControl> siteControls = new List<SiteControl>();
            using (SqlConnection conn = new SqlConnection(_connString))
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "SELECT Name, FilePath FROM Controls a " +
                	"JOIN PageControls b ON a.Id = b.ControlId " +
                    $"WHERE a.Id = b.ControlId AND b.PageName = '{pageName}' AND b.SiteId = {siteId.ToString()} ORDER BY b.SortOrder";
                conn.Open();
                using (SqlDataReader results = comm.ExecuteReader())
                {
                    if (results.HasRows)
                    {
                        while (results.Read())
                        {
                            siteControls.Add(new SiteControl
                            {
                                Name = results["Name"].ToString(),
                                Path = results["FilePath"].ToString()
                            });
                        }
                    }
                }
            }

            return siteControls;
        }
    }
}
