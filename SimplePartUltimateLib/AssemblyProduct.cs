using System;
namespace CarPartsUltimateLib
{
    public class AssemblyProduct : Product
    {
        public int AssemblyUkey { get; set; }
        public int RequiredQty { get; set; }
        public string Notes { get; set; }
        public string AssemblyIndex { get; set; }
        public AssemblyProduct()
        {
        }
    }
}
