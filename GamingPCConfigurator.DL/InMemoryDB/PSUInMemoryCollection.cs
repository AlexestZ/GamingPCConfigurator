using GamingPCConfigurator.Models;
using System.Collections.Generic;

namespace GamingPCConfigurator.DL.InMemoryDB
{
    public static class PSUInMemoryCollection
    {
        public static List<PSU> PSUDB = new List<PSU>()
        {
            new PSU()
            {
                ModelName = "GIGABYTE P550B 550W",
                Capacity = 550,
                Certificate = "80+ Bronze",
                Price = 116,
            },
            new PSU()
            {
                ModelName = "GIGABYTE P650B 650W",
                Capacity = 650,
                Certificate = "80+ Bronze",
                Price = 133,
            },
            new PSU()
            {
                ModelName = "SEASONIC B12-BC-750W",
                Capacity = 750,
                Certificate = "80+ Bronze",
                Price = 146,
            },
            new PSU()
            {
                ModelName = "SEASONIC G12-GC-650W",
                Capacity = 650,
                Certificate = "80+ Gold",
                Price = 161,
            },
            new PSU()
            {
                ModelName = "THERMALTAKE THOUGHPOWER GF1 ARGB 750W",
                Capacity = 750,
                Certificate = "80+ Gold",
                Price = 201,
            },
            new PSU()
            {
                ModelName = "GIGABYTE P850GM",
                Capacity = 850,
                Certificate = "80+ Gold",
                Price = 238,
            },
            new PSU()
            {
                ModelName = "GIGABYTE P1000GM",
                Capacity = 1000,
                Certificate = "80+ Gold",
                Price = 306,
            },
            new PSU()
            {
                ModelName = "ASUS ROG THOR 1200P 1200W",
                Capacity = 1200,
                Certificate = "80+ Platinum",
                Price = 699,
            },
        };
    }
}
