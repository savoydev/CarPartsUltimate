using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using CarPartsUltimateData;
using CarPartsUltimateLib;

namespace CarPartsUltimate.Controllers
{
    public class CategoriesController : ApiController
    {
        public IHttpActionResult GetCatgegories()
        {
            CategoryRepo categoryRepo = new CategoryRepo();
            List<ICategory> categories = categoryRepo.GetCategories();
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }
    }
}
