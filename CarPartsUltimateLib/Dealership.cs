using System;
namespace CarPartsUltimateLib
{
    public class Dealership : IDealership
    {
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string CityAddress { get; set; }
        public string StateAddress { get; set; }
        public string ZipCodeAddress { get; set; }
        public string CountryAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string PartsSiteUrl { get; set; }
        public string ServiceSiteUrl { get; set; }
        public string CarSiteUrl { get; set; }
        public bool Enabled { get; set; }
        public int Id { get; set; }
    }
}
