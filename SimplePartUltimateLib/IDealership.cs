namespace CarPartsUltimateLib
{
    public interface IDealership
    {
        string Name { get; set; }
        string StreetAddress { get; set; }
        string CityAddress { get; set; }
        string StateAddress { get; set; }
        string ZipCodeAddress { get; set; }
        string CountryAddress { get; set; }
        string PhoneNumber { get; set; }
        string PartsSiteUrl { get; set; }
        string ServiceSiteUrl { get; set; }
        string CarSiteUrl { get; set; }
        bool Enabled { get; set; }
        int Id { get; set; }
    }
}