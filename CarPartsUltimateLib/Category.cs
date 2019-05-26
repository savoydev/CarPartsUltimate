using System;
namespace CarPartsUltimateLib
{
    public class Category : ICategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IImage Image { get; set; }
        public string DestinationHref { get; set; }
        public Category()
        {
        }
    }
}
