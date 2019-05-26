using System;
namespace CarPartsUltimateLib
{
    public class Image : IImage
    {
        public int Id { get; set; }
        public string ThumbnailSource { get; set; }
        public string FullsizeSource { get; set; }
        public string Title { get; set; }
        public string Alt { get; set; }
    }
}
