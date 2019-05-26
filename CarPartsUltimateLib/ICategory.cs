namespace CarPartsUltimateLib
{
    public interface ICategory
    {
        int Id { get; set; }
        string Name { get; set; }
        IImage Image { get; set; }
        string DestinationHref { get; set; }
    }
}