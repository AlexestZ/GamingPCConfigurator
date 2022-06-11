using GamingPCConfigurator.Models;
using System.Collections.Generic;

namespace GamingPCConfigurator.DL.InMemoryDB
{
    public static class MotherboardInMemoryCollection
    {
        public static List<Motherboard> MotherboardDB = new List<Motherboard>()
        {
            new Motherboard()
            {
                PartNumber = 1,
                ModelName = "GIGABYTE B450M S2H",
                Socket = "AM4",
                Price = 140,
            },
            new Motherboard()
            {
                PartNumber = 2,
                ModelName = "ASROCK B550M STEEL LEGEND",
                Socket = "AM4",
                Price = 279,
            },
            new Motherboard()
            {
                PartNumber = 3,
                ModelName = "ASROCK B550 PRO4",
                Socket = "AM4",
                Price = 284,
            },
            new Motherboard()
            {
                PartNumber = 4,
                ModelName = "ASUS PRIME X570-P",
                Socket = "AM4",
                Price = 408,
            },
            new Motherboard()
            {
                PartNumber = 5,
                ModelName = "ASROCK B660M-HDV",
                Socket = "LGA1700",
                Price = 233,
            },
            new Motherboard()
            {
                PartNumber = 6,
                ModelName = "GIGABYTE B660 GAMING X DDR4",
                Socket = "LGA1700",
                Price = 344,
            },
            new Motherboard()
            {
                PartNumber = 7,
                ModelName = "ASROCK Z690 PHANTOM GAMING 4",
                Socket = "LGA1700",
                Price = 419,
            },
        };
    }
}         