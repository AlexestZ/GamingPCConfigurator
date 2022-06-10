namespace GamingPCConfigurator.Models
{
    public class CPU
    {
        public string ManufacturerName { get; set; }
        public string Model { get; set; }
        public string Socket { get; set; }
        public int PerformanceRating { get; set; }
        public string BestResolution { get; set; }
        public int CoreCount { get; set; }
        public int ThreadCount { get; set; }
        public int PowerDraw { get; set; }
        public bool IncludedFan { get; set; }
        public double Price { get; set; }
    }
}
