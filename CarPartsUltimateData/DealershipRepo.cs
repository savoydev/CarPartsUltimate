using System;
using System.Collections.Generic;
using CarPartsUltimateLib;

namespace CarPartsUltimateData
{
    public class DealershipRepo : IDealershipRepo
    {
        public List<IDealership> GetNearestDealerships()
        {
            return DummmyDealer3();
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
