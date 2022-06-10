using GamingPCConfigurator.Models;
using System.Collections.Generic;

namespace GamingPCConfigurator.DL.InMemoryDB
{
    public static class VideocardInMemoryCollection
    {
        public static List<Videocard> VideocardDB = new List<Videocard>()
        {
            new Videocard()
            {
                ManufacturerName = "POWERCOLOR",
                ModelName = "POWERCOLOR AMD RADEON RX 6400 4G",
                PerformanceRating = 1,
                Price = 1,
            },

        };
    }
}
