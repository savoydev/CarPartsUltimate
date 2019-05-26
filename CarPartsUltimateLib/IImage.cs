namespace CarPartsUltimateLib
{
    public interface IImage
    {
        int Id { get; set; }
        string ThumbnailSource { get; set; }
        string FullsizeSource { get; set; }
        string Title { get; set; }
        string Alt { get; set; }
    }
}