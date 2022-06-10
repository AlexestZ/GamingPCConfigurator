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
                ModelName = "TEAM GROUP GX2 128GB",
                Interface = "SATA III",
                Capacity = 128,
                Price = 36,
            },
            new SSD()
            {
                ModelName = "TEAM GROUP GX2 256GB",
                Interface = "SATA III",
                Capacity = 256,
                Price = 59,
            },
            new SSD()
            {
                ModelName = "TEAM GROUP GX2 512GB",
                Interface = "SATA III",
                Capacity = 512,
                Price = 99,
            },
            new SSD()
            {
                ModelName = "TEAM GROUP GX2 1TB",
                Interface = "SATA III",
                Capacity = 1000,
                Price = 199,
            },
            new SSD()
            {
                ModelName = "SAMSUNG 870 QVO 2TB",
                Interface = "SATA III",
                Capacity = 2000,
                Price = 411,
            },
            new SSD()
            {
                ModelName = "SILICON POWER UD80 250GB",
                Interface = "PCIe Gen 3.0",
                Capacity = 250,
                Price = 78,
            },           
            new SSD()
            {
                ModelName = "T-FORCE CARDEA Z44L 500GB",
                Interface = "PCIe Gen 4.0",
                Capacity = 500,
                Price = 135,
            },
            new SSD()
            {
                ModelName = "SAMSUNG 980 NVME M.2 SSD 1TB",
                Interface = "PCIe Gen 3.0",
                Capacity = 1000,
                Price = 209,
            },
            new SSD()
            {
                ModelName = "T-FORCE CARDEA Z44L 1TB",
                Interface = "PCIe Gen 4.0",
                Capacity = 1000,
                Price = 251,
            },
            new SSD()
            {
                ModelName = "AORUS GEN4 NVME 2TB",
                Interface = "PCIe Gen 4.0",
                Capacity = 2000,
                Price = 564,
            },
            new SSD()
            {
                ModelName = "SILICON POWER P34A80 NVME 2TB",
                Interface = "PCIe Gen 3.0",
                Capacity = 2000,
                Price = 438,
            },
        };
    }
}
