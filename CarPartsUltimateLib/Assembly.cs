using System;
using System.Collections.Generic;

namespace CarPartsUltimateLib
{
    public class Assembly : IAssembly
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Image> Images { get; set; }
    }
}
