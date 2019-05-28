using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using CarPartsUltimateData;
using CarPartsUltimateLib;

namespace CarPartsUltimate.Controllers
{
    public class CategoriesController : ApiController
    {
        private string _connString = ConfigurationManager.ConnectionStrings["masterConnection"].ToString();

        public IHttpActionResult GetCatgegories()
        {
            ICategoryRepo categoryRepo = new CategoryRepo(_connString);
            List<ICategory> categories = categoryRepo.GetCategories();
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }
    }
}
