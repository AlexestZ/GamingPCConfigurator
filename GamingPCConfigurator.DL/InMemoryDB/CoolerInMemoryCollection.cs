using GamingPCConfigurator.Models;
using System.Collections.Generic;

namespace GamingPCConfigurator.DL.InMemoryDB
{
    public static class CoolerInMemoryCollection
    {
        public static List<Cooler> CoolerDB = new List<Cooler>()
        {
            new Cooler()
            {                
                ModelName = "ARCTIC FREEZER 7 X",
                AirFlow = 53,
                Height = 133,
                Price = 47
            },
            new Cooler()
            {
                ModelName = "ARCTIC FREEZER 34 Red ESPORTS",
                AirFlow = 68,
                Height = 157,
                Price = 57
            },
             new Cooler()
            {
                ModelName = "COOLER MASTER HYPER 212 LED WHITE EDITION",
                AirFlow = 66,
                Height = 158,
                Price = 84
            },
             new Cooler()
             {
                ModelName = "NOCTUA NH-U9S",
                AirFlow = 46,
                Height = 125,
                Price = 128
             },
             new Cooler()
             {
                ModelName = "NOCTUA NH-D15",
                AirFlow = 83,
                Height = 165,
                Price = 187
             },
             new Cooler()
             {
                ModelName = "NOCTUA NH-D15S CHROMAX.BLACK",
                AirFlow = 83,
                Height = 160,
                Price = 195
             }
        };
    }    
}
