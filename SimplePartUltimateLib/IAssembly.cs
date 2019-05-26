using System.Collections.Generic;

namespace CarPartsUltimateLib
{
    public interface IAssembly
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        List<Image> Images { get; set; }
    }
}