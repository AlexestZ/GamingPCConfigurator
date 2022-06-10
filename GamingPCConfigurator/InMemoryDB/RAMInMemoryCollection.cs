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
                ModelName = "KINGSTON FURY BEAST BLACK 8GB 3200MHZ",
                Capacity = 8,
                Frequency = 3200,
                Price = 70,
            },
            new RAM()
            {
                ModelName = "KINGSTON FURY BEAST BLACK 8GB DDR4 PC4-28800 3600MHZ",
                Capacity = 8,
                Frequency = 3600,
                Price = 89,
            },
            new RAM()
            {
                ModelName = "G.SKILL AEGIS 16GB 3200MHZ",
                Capacity = 16,
                Frequency = 3200,
                Price = 118,
            },
            new RAM()
            {
                ModelName = "KINGSTON FURY BEAST BLACK 16GB 3600MHZ",
                Capacity = 16,
                Frequency = 3600,
                Price = 147,
            },
         };
    }
}
