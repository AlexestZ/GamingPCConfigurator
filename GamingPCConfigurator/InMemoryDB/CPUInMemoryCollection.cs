using GamingPCConfigurator.Models;
using System.Collections.Generic;

namespace GamingPCConfigurator.DL.InMemoryDB
{
    public static class CPUInMemoryCollection
    {
        public static List<CPU> CPUDB = new List<CPU>()
        {
            new CPU()
            {
                PartNumber = 1,
                ManufacturerName = "INTEL",
                Model = "INTEL CORE I3-12100F",
                Socket = "LGA1700",
                PerformanceRating = 137,
                BestResolution = "FHD",
                CoreCount = 4,
                ThreadCount = 8,
                PowerDraw = 89,
                Price = 239
            },
            new CPU()
            {
                PartNumber = 2,
                ManufacturerName = "AMD",
                Model = "AMD RYZEN 5 5500",
                Socket = "AM4",
                PerformanceRating = 129,
                BestResolution = "FHD",
                CoreCount = 6,
                ThreadCount = 12,
                PowerDraw = 65,
                Price = 320
            },
             new CPU()
            {
                 PartNumber = 3,
                ManufacturerName = "INTEL",
                Model = "INTEL CORE I5-12400F",
                Socket = "LGA1700",
                PerformanceRating = 155,
                BestResolution = "2K",
                CoreCount = 6,
                ThreadCount = 12,
                PowerDraw = 117,
                Price = 413
            },
             new CPU()
             {
                 PartNumber = 4,
               ManufacturerName = "AMD",
                Model = "AMD RYZEN 5 5600",
                Socket = "LGA1700",
                PerformanceRating = 152,
                BestResolution = "2K",
                CoreCount = 6,
                ThreadCount = 12,
                PowerDraw = 74,
                Price = 463
             },
             new CPU()
             {
                 PartNumber = 5,
                ManufacturerName = "AMD",
                Model = "AMD RYZEN 7 5800X",
                Socket = "AM4",
                PerformanceRating = 157,
                BestResolution = "4K",
                CoreCount = 8,
                ThreadCount = 16,
                PowerDraw = 118,
                Price = 765
             },
             new CPU()
             {
                 PartNumber = 6,
                ManufacturerName = "INTEL",
                Model = "INTEL CORE I7-12700KF",
                Socket = "LGA1700",
                PerformanceRating = 178,
                BestResolution = "4K",
                CoreCount = 12,
                ThreadCount = 20,
                PowerDraw = 150,
                Price = 966
             },
             new CPU()
             {
                 PartNumber = 7,
                ManufacturerName = "AMD",
                Model = "AMD RYZEN 7 5800X3D",
                Socket = "AM4",
                PerformanceRating = 201,
                BestResolution = "4K",
                CoreCount = 8,
                ThreadCount = 16,
                PowerDraw = 110,
                Price = 999
             }
        };
    }
}
