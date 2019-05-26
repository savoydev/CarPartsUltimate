using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using CarPartsUltimateData;
using CarPartsUltimateLib;

namespace CarPartsUltimate.Controllers
{
    public class FitmentController : ApiController
    {
        public IHttpActionResult GetFitmentLinks()
        {
            FitmentRepo fitmentRepo = new FitmentRepo();
            List<RefineFitmentLink> refineFitmentLinks = fitmentRepo.GetRefineLinks();
            if (refineFitmentLinks == null)
            {
                return NotFound();
            }
            return Ok(refineFitmentLinks);
        }
    }
}
