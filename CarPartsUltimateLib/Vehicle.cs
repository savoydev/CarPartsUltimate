using System;
namespace CarPartsUltimateLib
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string MakeName { get; set; }
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int DrivetrainId { get; set; }
        public string DrivetrainName { get; set; }
        public int TrimId { get; set; }
        public string TrimName { get; set; }
        public string Year { get; set; }
    }
}
