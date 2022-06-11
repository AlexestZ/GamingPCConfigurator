using GamingPCConfigurator.Models;
using System.Collections.Generic;

namespace GamingPCConfigurator.DL.InMemoryDB
{
    public static class SSDInMemoryCollection
    {
        public static List<SSD> SSDDB = new List<SSD>()
        {            
            new SSD()
            {
                PartNumber = 1,
                ModelName = "TEAM GROUP GX2 256GB",
                Interface = "SATA III",
                Capacity = 256,
                Price = 59,
            },
            new SSD()
            {
                PartNumber = 2,
                ModelName = "TEAM GROUP GX2 512GB",
                Interface = "SATA III",
                Capacity = 512,
                Price = 99,
            },                   
            new SSD()
            {
                PartNumber = 3,
                ModelName = "SILICON POWER UD80 250GB",
                Interface = "PCIe Gen 3.0",
                Capacity = 250,
                Price = 78,
            },           
            new SSD()
            {
                PartNumber = 4,
                ModelName = "T-FORCE CARDEA Z44L 500GB",
                Interface = "PCIe Gen 4.0",
                Capacity = 500,
                Price = 135,
            },
            new SSD()
            {
                PartNumber = 5,
                ModelName = "SAMSUNG 980 NVME M.2 SSD 1TB",
                Interface = "PCIe Gen 3.0",
                Capacity = 1000,
                Price = 209,
            },
            new SSD()
            {
                PartNumber = 6, 
                ModelName = "T-FORCE CARDEA Z44L 1TB",
                Interface = "PCIe Gen 4.0",
                Capacity = 1000,
                Price = 251,
            },
            new SSD()
            {
                PartNumber = 7,
                ModelName = "SILICON POWER P34A80 NVME 2TB",
                Interface = "PCIe Gen 3.0",
                Capacity = 2000,
                Price = 438,
            },
            new SSD()
            {
                PartNumber = 8,
                ModelName = "AORUS GEN4 NVME 2TB",
                Interface = "PCIe Gen 4.0",
                Capacity = 2000,
                Price = 564,
            },            
        };
    }
}
