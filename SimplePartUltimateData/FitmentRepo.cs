using System;
using System.Collections.Generic;
using CarPartsUltimateLib;

namespace CarPartsUltimateData
{
    public class FitmentRepo : IFitmentRepo
    {
        public List<RefineFitmentLink> GetRefineLinks()
        {
            return GetDummyRefineLinks();
        }

        private List<RefineFitmentLink> GetDummyRefineLinks()
        {
            List<RefineFitmentLink> refineLinks = new List<RefineFitmentLink>
            {
                new RefineFitmentLink()
                {
                    Name = "Cars",
                    Title = "Click to view cars",
                    Image = new Image()
                    {
                        ThumbnailSource = "https://42f2671d685f51e10fc6-b9fcecea3e50b3b59bdc28dead054ebc.ssl.cf5.rackcdn.com/illustrations/electric_car_b7hl.svg",
                        FullsizeSource = "https://42f2671d685f51e10fc6-b9fcecea3e50b3b59bdc28dead054ebc.ssl.cf5.rackcdn.com/illustrations/electric_car_b7hl.svg"
                    }
                },
                new RefineFitmentLink()
                {
                    Name = "Convertibles",
                    Title = "Click to view convertible",
                    Image = new Image()
                    {
                        ThumbnailSource = "https://42f2671d685f51e10fc6-b9fcecea3e50b3b59bdc28dead054ebc.ssl.cf5.rackcdn.com/illustrations/fast_car_p4cu.svg",
                        FullsizeSource = "https://42f2671d685f51e10fc6-b9fcecea3e50b3b59bdc28dead054ebc.ssl.cf5.rackcdn.com/illustrations/fast_car_p4cu.svg"
                    }
                },
                new RefineFitmentLink()
                {
                    Name = "Off-road",
                    Title = "Click to view off-road vehicles",
                    Image = new Image()
                    {
                        ThumbnailSource = "https://42f2671d685f51e10fc6-b9fcecea3e50b3b59bdc28dead054ebc.ssl.cf5.rackcdn.com/illustrations/off_road_9oae.svg",
                        FullsizeSource = "https://42f2671d685f51e10fc6-b9fcecea3e50b3b59bdc28dead054ebc.ssl.cf5.rackcdn.com/illustrations/off_road_9oae.svg"
                    }
                },
                new RefineFitmentLink()
                {
                    Name = "Hybrids",
                    Title = "Click to view hybrids",
                    Image = new Image()
                    {
                        ThumbnailSource = "https://42f2671d685f51e10fc6-b9fcecea3e50b3b59bdc28dead054ebc.ssl.cf5.rackcdn.com/illustrations/by_my_car_ttge.svg",
                        FullsizeSource = "https://42f2671d685f51e10fc6-b9fcecea3e50b3b59bdc28dead054ebc.ssl.cf5.rackcdn.com/illustrations/by_my_car_ttge.svg"
                    }
                },
                new RefineFitmentLink()
                {
                    Name = "Compacts",
                    Title = "Click to view compacts",
                    Image = new Image()
                    {
                        ThumbnailSource = "https://42f2671d685f51e10fc6-b9fcecea3e50b3b59bdc28dead054ebc.ssl.cf5.rackcdn.com/illustrations/city_driver_jh2h.svg",
                        FullsizeSource = "https://42f2671d685f51e10fc6-b9fcecea3e50b3b59bdc28dead054ebc.ssl.cf5.rackcdn.com/illustrations/city_driver_jh2h.svg"
                    }
                }
            };

            return refineLinks;
        }
    }
}
