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
                ModelName = "GIGABYTE B450M S2H",
                Socket = "AM4",
                RAMSlots = 2,
                Price = 140,
            },
            new Motherboard()
            {
                ModelName = "ASROCK B550M STEEL LEGEND",
                Socket = "AM4",
                RAMSlots = 4,
                Price = 279,
            },
            new Motherboard()
            {
                ModelName = "ASROCK B550 PRO4",
                Socket = "AM4",
                RAMSlots = 4,
                Price = 284,
            },
            new Motherboard()
            {
                ModelName = "ASUS PRIME X570-P",
                Socket = "AM4",
                RAMSlots = 4,
                Price = 408,
            },
            new Motherboard()
            {
                ModelName = "ASROCK B660M-HDV",
                Socket = "LGA1700",
                RAMSlots = 2,
                Price = 233,
            },
            new Motherboard()
            {
                ModelName = "GIGABYTE B660 GAMING X DDR4",
                Socket = "LGA1700",
                RAMSlots = 4,
                Price = 344,
            },
            new Motherboard()
            {
                ModelName = "ASROCK Z690 PHANTOM GAMING 4",
                Socket = "LGA1700",
                RAMSlots = 4,
                Price = 419,
            },
        };
    }
}