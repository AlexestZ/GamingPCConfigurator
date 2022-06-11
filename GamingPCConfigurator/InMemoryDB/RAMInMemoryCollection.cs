using GamingPCConfigurator.Models;
using System.Collections.Generic;

namespace GamingPCConfigurator.DL.InMemoryDB
{
    public static class RAMInMemoryCollection
    {
        public static List<RAM> RAMDB = new List<RAM>()
        {
            new RAM()
            {
                PartNumber = 1,
                ModelName = "KINGSTON FURY BEAST BLACK 8GB",
                Capacity = 8,
                Frequency = 3200,
                Price = 70,
            },
            new RAM()
            {
                PartNumber = 2,
                ModelName = "KINGSTON FURY BEAST BLACK 8GB",
                Capacity = 8,
                Frequency = 3600,
                Price = 89,
            },
             new RAM()
            {
                PartNumber = 3,
                ModelName = "T-FORCE VULCAN TUF 16GB (2X8GB)",
                Capacity = 16,
                Frequency = 3200,
                Price = 136,
            },
              new RAM()
            {
                PartNumber = 4,
                ModelName = "KINGSTON FURY BEAST BLACK 16GB (2X8GB)",
                Capacity = 16,
                Frequency = 3600,
                Price = 193,
            },
               new RAM()
            {
                PartNumber = 5,
                ModelName = "T-FORCE DELTA RGB TUF 32GB (2X16GB)",
                Capacity = 32,
                Frequency = 3200,
                Price = 300,
            },
                new RAM()
            {
                PartNumber = 6,
                ModelName = "KINGSTON FURY BEAST BLACK 64GB (2X32GB)",
                Capacity = 64,
                Frequency = 3200,
                Price = 560,
            },
        };
    }
}