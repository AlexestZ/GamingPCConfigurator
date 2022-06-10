using GamingPCConfigurator.Models;
using System.Collections.Generic;

namespace GamingPCConfigurator.DL.InMemoryDB
{
    public static class CaseInMemoryCollection
    {
        public static List<Case> CaseDB = new List<Case>()
        {
            new Case()
            {
                ManufacturerName = "Thermaltake",
                ModelName = "Thermaltake Versa H17",
                Color = "Black",
                Size = "MiniTower",
                CoolerHeightCapacity = 155,
                Price = 85
            },
            new Case()
            {
                ManufacturerName = "Thermaltake",
                ModelName = "Thermaltake S100 TG",
                Color = "Darkgray",
                Size = "MiniTower",
                 CoolerHeightCapacity = 165,
                Price = 119
            },
             new Case()
            {
                 ManufacturerName = "Thermaltake",
                ModelName = "Thermaltake S100 TG",
                Color = "White",
                Size = "MiniTower",
                 CoolerHeightCapacity = 165,
                Price = 129
            },
             new Case()
             {
                  ManufacturerName = "Thermaltake",
                ModelName = "Thermaltake H330 TG",
                Color = "Black",
                Size = "MidTower",
                 CoolerHeightCapacity = 150,
                Price = 119
             },
             new Case()
             {
                  ManufacturerName = "Thermaltake",
                ModelName = "Thermaltake H200 TG Snow RGB",
                Color = "White",
                Size = "MidTower",
                 CoolerHeightCapacity = 180,
                Price = 189
             },
             new Case()
             {
                 ManufacturerName = "Corsair",
                ModelName = "Corsair 4000D TG",
                Color = "White, Gray",
                Size = "MidTower",
                 CoolerHeightCapacity = 170,
                Price = 229
             }
        };
    }
}
