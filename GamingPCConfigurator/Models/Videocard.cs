namespace GamingPCConfigurator.Models
{
    public class Videocard
    {
        public string ManufacturerName { get; set; }
        public string ModelName { get; set; }
        public int CoreCount { get; set; }
        public int PerformanceRating { get; set; }
        public int RayTracingPerformanceRating { get; set; }
        public string BestResolution { get; set; }

        public double Price { get; set; }
    }
}
