using GamingPCConfigurator.DL.InMemoryDB;
using GamingPCConfigurator.Models;
using System;
using System.Collections.Generic;

namespace GamingPCConfigurator.Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[][] partsMatrix = new string[8][];           
            Console.WriteLine("Welcome to the GamingPCConfigurator\r\n");
            Console.WriteLine("What is your desired resolution for playing games ?\r\n");
            Console.WriteLine("Please choose from the following: FHD, 2K or 4K and write your preference\r\n");

            string chosenResolution = Console.ReadLine().ToUpper();
            if (chosenResolution != "FHD" && chosenResolution != "2K" && chosenResolution != "4K")
            {
                Console.WriteLine("Wrong resolution. Try again with one of the following: FHD, 2K or 4K\r\n");
                chosenResolution = Console.ReadLine().ToUpper();
            }
            Console.WriteLine($"\r\nYou have chosen {chosenResolution}.We will offer you parts which are good for gaming at this resolution. \r\n");
            Console.WriteLine("First you have to choose a Motherboard for your gaming computer. \r\n");

            PrintingMotherBoardList(MotherboardInMemoryCollection.MotherboardDB, partsMatrix);

            int chosenMotherboardNumber = int.Parse(Console.ReadLine()) - 1;

            SavingMotherBoardData(chosenMotherboardNumber, partsMatrix);

            PrintingAndSavingProcessorData(CPUInMemoryCollection.CPUDB, chosenResolution, chosenMotherboardNumber, partsMatrix);

            PrintingCoolerList(partsMatrix);

            int chosenCoolerNumber = int.Parse(Console.ReadLine()) - 1;

            SavingCoolerData(chosenCoolerNumber, partsMatrix);

            PrintingRAMList();
            int chosenRAMNumber = int.Parse(Console.ReadLine()) - 1;

            SavingRAMData(chosenRAMNumber, partsMatrix);

            PrintingVideocardList(chosenResolution);

            int chosenVideocardNumber = int.Parse(Console.ReadLine()) - 1;

            SavingVideocardData(chosenVideocardNumber, chosenResolution, partsMatrix);

            PrintingAndSavingSSDData(partsMatrix);

            PrintingAndSavingPSUData(chosenVideocardNumber, partsMatrix);

            PrintingAndSavingCaseData(chosenCoolerNumber, partsMatrix);

            PrintingConfiguration(partsMatrix);
        }

        private static void PrintingConfiguration(string[][] partsMatrix)
        {
            Console.WriteLine($"\r\nYour configuration contains the following parts:\r\n");         
            int totalSum = 0;
            for (int i = 0; i < partsMatrix.GetLength(0); i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("Motherboard: ");
                        break;
                    case 1:
                        Console.Write("Processor: ");
                        break;
                    case 2:
                        Console.Write("Cooler: ");
                        break;
                    case 3:
                        Console.Write("RAM: ");
                        break;
                    case 4:
                        Console.Write("Videocard: ");
                        break;
                    case 5:
                        Console.Write("SSD: ");
                        break;
                    case 6:
                        Console.Write("PSU: ");
                        break;
                    case 7:
                        Console.Write("Case: ");
                        break;
                }
                for (int j = 0; j < partsMatrix[i].Length; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(partsMatrix[i][j] + ", ");
                    }
                    else
                    {
                        Console.Write($"Price: {partsMatrix[i][j]} BGN;");
                        totalSum += int.Parse(partsMatrix[i][j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\r\nTotal price for your configurated gaming computer is: {totalSum} BGN.\r\n");
        }

        private static void PrintingAndSavingCaseData(int chosenCoolerNumber, string[][] partsMatrix)
        {
            Console.WriteLine($"\r\nNow you have to choose case for your gaming computer.\r\n");

            for (int i = 0; i < CaseInMemoryCollection.CaseDB.Count; i++)
            {
                if (CaseInMemoryCollection.CaseDB[i].CoolerHeightCapacity > CoolerInMemoryCollection.CoolerDB[chosenCoolerNumber].Height)
                {
                    Console.Write($"Part№:{CaseInMemoryCollection.CaseDB[i].PartNumber}, ");
                    Console.Write($"Model:{CaseInMemoryCollection.CaseDB[i].ModelName}, ");
                    Console.Write($"Color:{CaseInMemoryCollection.CaseDB[i].Color}, ");
                    Console.Write($"Size:{CaseInMemoryCollection.CaseDB[i].Size}, ");
                    Console.Write($"Cooler height max:{CaseInMemoryCollection.CaseDB[i].CoolerHeightCapacity} mm, ");
                    Console.Write($"Price:{CaseInMemoryCollection.CaseDB[i].Price} BGN; \r\n");
                }
            }
            Console.WriteLine($"\r\nWrite the part number of the case that you have chosen.\r\n");

            int chosenCaseNumber = int.Parse(Console.ReadLine()) - 1;

            while (chosenCaseNumber < 0 || chosenCaseNumber >= CaseInMemoryCollection.CaseDB.Count || CaseInMemoryCollection.CaseDB[chosenCaseNumber].CoolerHeightCapacity <= CoolerInMemoryCollection.CoolerDB[chosenCoolerNumber].Height)
            {
                Console.WriteLine($"\r\nIncorrect part number.Choose case from the listed above.");
                chosenCaseNumber = int.Parse(Console.ReadLine()) - 1;
            }        
            string[] caseSpecs = new string[2];
            caseSpecs[0] = CaseInMemoryCollection.CaseDB[chosenCaseNumber].ModelName.ToString();
            caseSpecs[1] = CaseInMemoryCollection.CaseDB[chosenCaseNumber].Price.ToString();

            partsMatrix[7] = caseSpecs;
        }

        private static void PrintingAndSavingPSUData(int chosenVideocardNumber, string[][] partsMatrix)
        {
            Console.WriteLine($"\r\nNow you have to choose PSU for your gaming computer. We will suggest you only models which can handle the power draw of your chosen parts.\r\n");

            for (int i = 0; i < PSUInMemoryCollection.PSUDB.Count; i++)
            {
                if (PSUInMemoryCollection.PSUDB[i].Capacity >= VideocardInMemoryCollection.VideocardDB[chosenVideocardNumber].PowerRequirement)
                {
                    Console.Write($"Part№:{PSUInMemoryCollection.PSUDB[i].PartNumber}, ");
                    Console.Write($"Model:{PSUInMemoryCollection.PSUDB[i].ModelName}, ");
                    Console.Write($"Capacity:{PSUInMemoryCollection.PSUDB[i].Capacity} W, ");
                    Console.Write($"Certificate:{PSUInMemoryCollection.PSUDB[i].Certificate}, ");
                    Console.Write($"Price:{PSUInMemoryCollection.PSUDB[i].Price} BGN; \r\n");
                }
            }          
            Console.WriteLine($"\r\nWrite the part number of the PSU that you have chosen.\r\n");

            int chosenPSUNumber = int.Parse(Console.ReadLine()) - 1;

            while (chosenPSUNumber < 0 || chosenPSUNumber >= PSUInMemoryCollection.PSUDB.Count || PSUInMemoryCollection.PSUDB[chosenPSUNumber].Capacity < VideocardInMemoryCollection.VideocardDB[chosenVideocardNumber].PowerRequirement)
            {
                Console.WriteLine($"\r\nIncorrect part number.Choose PSU from the listed above.");
                chosenPSUNumber = int.Parse(Console.ReadLine()) - 1;
            }           
            string[] psuSpecs = new string[2];
            psuSpecs[0] = PSUInMemoryCollection.PSUDB[chosenPSUNumber].ModelName;
            psuSpecs[1] = PSUInMemoryCollection.PSUDB[chosenPSUNumber].Price.ToString();

            partsMatrix[6] = psuSpecs;
        }

        private static void PrintingAndSavingSSDData(string[][] partsMatrix)
        {
            Console.WriteLine($"\r\nNow you have to choose SSD for your gaming computer.\r\n");

            for (int i = 0; i < SSDInMemoryCollection.SSDDB.Count; i++)
            {
                Console.Write($"Part№:{SSDInMemoryCollection.SSDDB[i].PartNumber}, ");
                Console.Write($"Model:{SSDInMemoryCollection.SSDDB[i].ModelName}, ");
                Console.Write($"Interface:{SSDInMemoryCollection.SSDDB[i].Interface}, ");
                Console.Write($"Capacity:{SSDInMemoryCollection.SSDDB[i].Capacity} GB, ");
                Console.Write($"Price:{SSDInMemoryCollection.SSDDB[i].Price} BGN; \r\n");
            }
            Console.WriteLine($"\r\nWrite the part number of the SSD that you have chosen.\r\n");

            int chosenSSDNumber = int.Parse(Console.ReadLine()) - 1;

            while (chosenSSDNumber < 0 || chosenSSDNumber >= SSDInMemoryCollection.SSDDB.Count)
            {
                Console.WriteLine($"\r\nIncorrect part number.Choose SSD from the listed above.\r\n");
                chosenSSDNumber = int.Parse(Console.ReadLine()) - 1;
            }
            string[] ssdSpecs = new string[2];
            ssdSpecs[0] = SSDInMemoryCollection.SSDDB[chosenSSDNumber].ModelName.ToString();
            ssdSpecs[1] = SSDInMemoryCollection.SSDDB[chosenSSDNumber].Price.ToString();

            partsMatrix[5] = ssdSpecs;
        }

        private static void SavingVideocardData(int chosenVideocardNumber, string chosenResolution, string[][] partsMatrix)
        {
            while (chosenVideocardNumber < 0 || chosenVideocardNumber >= VideocardInMemoryCollection.VideocardDB.Count || VideocardInMemoryCollection.VideocardDB[chosenVideocardNumber].BestResolution != chosenResolution)
            {
                Console.WriteLine("\r\nIncorrect part number.Choose a videocard from the listed above.\r\n");
                chosenVideocardNumber = int.Parse(Console.ReadLine()) - 1;
            }          
            string[] videocardSpecs = new string[2];
            videocardSpecs[0] = VideocardInMemoryCollection.VideocardDB[chosenVideocardNumber].ModelName;
            videocardSpecs[1] = VideocardInMemoryCollection.VideocardDB[chosenVideocardNumber].Price.ToString();

            partsMatrix[4] = videocardSpecs;
        }

        private static void PrintingVideocardList(string chosenResolution)
        {
            Console.WriteLine($"\r\nNow you have to choose videocard for your gaming computer.We have suggested only videocards for your desired gaming resolution. If you want to enable Ray Tracing in your games you should watch the RT Gaming scores.\r\n");

            for (int i = 0; i < VideocardInMemoryCollection.VideocardDB.Count; i++)
            {
                if (VideocardInMemoryCollection.VideocardDB[i].BestResolution == chosenResolution)
                {
                    Console.Write($"Part№:{VideocardInMemoryCollection.VideocardDB[i].PartNumber}, ");
                    Console.Write($"Model:{VideocardInMemoryCollection.VideocardDB[i].ModelName}, ");
                    Console.Write($"Gaming:{VideocardInMemoryCollection.VideocardDB[i].PerformanceRating} Pts, ");
                    Console.Write($"RT Gaming:{VideocardInMemoryCollection.VideocardDB[i].RayTracingPerformanceRating} Pts, ");
                    Console.Write($"BestResolution:{VideocardInMemoryCollection.VideocardDB[i].BestResolution}, ");
                    Console.Write($"Price:{VideocardInMemoryCollection.VideocardDB[i].Price} BGN; \r\n");
                }
            }
            Console.WriteLine($"\r\nWrite the Part number of the videocard that you have chosen.\r\n");
        }

        private static void SavingRAMData(int chosenRAMNumber, string[][] partsMatrix)
        {
            while (chosenRAMNumber < 0 || chosenRAMNumber >= RAMInMemoryCollection.RAMDB.Count)
            {
                Console.WriteLine("\r\nIncorrect part number.Choose RAM from the listed above.\r\n");
                chosenRAMNumber = int.Parse(Console.ReadLine()) - 1;
            }
            string[] ramSpecs = new string[2];
            ramSpecs[0] = RAMInMemoryCollection.RAMDB[chosenRAMNumber].ModelName;
            ramSpecs[1] = RAMInMemoryCollection.RAMDB[chosenRAMNumber].Price.ToString();

            partsMatrix[3] = ramSpecs;
        }

        private static void PrintingRAMList()
        {
            Console.WriteLine("\r\nNow you have to choose RAM for your gaming computer.If you are on tight budget we recommend getting 1 stick and buying another in the near future. If your budget is enough you should get 2 sticks for Dual Channel which increases performance. 16GB of RAM are enough for gaming. But if you want to stream we recommend getting 32 GB of RAM. 64 GB of RAM is only needed if you want to be future-proof.\r\n");

            for (int i = 0; i < RAMInMemoryCollection.RAMDB.Count; i++)
            {
                Console.Write($"Part№:{RAMInMemoryCollection.RAMDB[i].PartNumber}, ");
                Console.Write($"Model:{RAMInMemoryCollection.RAMDB[i].ModelName}, ");
                Console.Write($"Capacity:{RAMInMemoryCollection.RAMDB[i].Capacity} GB, ");
                Console.Write($"Frequency:{RAMInMemoryCollection.RAMDB[i].Frequency} MHz, ");
                Console.Write($"Price:{RAMInMemoryCollection.RAMDB[i].Price} BGN; \r\n");
            }
            Console.WriteLine($"\r\nWrite the part number of the RAM that you have chosen.\r\n");
        }

        private static void SavingCoolerData(int chosenCoolerNumber, string[][] partsMatrix)
        {
            while (chosenCoolerNumber < 0 || chosenCoolerNumber >= CoolerInMemoryCollection.CoolerDB.Count)
            {
                Console.WriteLine("\r\nIncorrect part number.Choose a cooler from the listed above.\r\n");
                chosenCoolerNumber = int.Parse(Console.ReadLine()) - 1;
            }
            string[] coolerSpecs = new string[2];
            coolerSpecs[0] = CoolerInMemoryCollection.CoolerDB[chosenCoolerNumber].ModelName;
            coolerSpecs[1] = CoolerInMemoryCollection.CoolerDB[chosenCoolerNumber].Price.ToString();

            partsMatrix[2] = coolerSpecs;
        }

        private static void PrintingCoolerList(string[][] partsMatrix)
        {
            Console.WriteLine("\r\nNow you have to choose cooler for your gaming computer. More powerful and power hungry processors need better cooling.\r\n");

            for (int i = 0; i < CoolerInMemoryCollection.CoolerDB.Count; i++)
            {
                Console.Write($"Part№:{CoolerInMemoryCollection.CoolerDB[i].PartNumber}, ");
                Console.Write($"Model:{CoolerInMemoryCollection.CoolerDB[i].ModelName}, ");
                Console.Write($"AirFlow:{CoolerInMemoryCollection.CoolerDB[i].AirFlow} CFM, ");
                Console.Write($"Height:{CoolerInMemoryCollection.CoolerDB[i].Height} mm, ");
                Console.Write($"Price:{CoolerInMemoryCollection.CoolerDB[i].Price} BGN; \r\n");
            }
            Console.WriteLine($"\r\nWrite the part number of the cooler that you have chosen.\r\n");
        }

        private static void SavingMotherBoardData(int chosenMotherboardNumber, string[][] partsMatrix)
        {       
            while (chosenMotherboardNumber < 0 || chosenMotherboardNumber >= MotherboardInMemoryCollection.MotherboardDB.Count)
            {
                Console.WriteLine("\r\nIncorrect part number.Choose a motherboard from the listed above.\r\n");
                chosenMotherboardNumber = int.Parse(Console.ReadLine()) - 1;
            }
            string[] motherboardSpecs = new string[2];
            motherboardSpecs[0] = MotherboardInMemoryCollection.MotherboardDB[chosenMotherboardNumber].ModelName.ToString();
            motherboardSpecs[1] = MotherboardInMemoryCollection.MotherboardDB[chosenMotherboardNumber].Price.ToString();

            partsMatrix[0] = motherboardSpecs;
        }

        private static void PrintingAndSavingProcessorData(List<CPU> CPUDB, string chosenResolution, int chosenMotherboardNumber, string[][] partsMatrix)
        {
            Console.WriteLine($"Chosen motherboard is: {MotherboardInMemoryCollection.MotherboardDB[chosenMotherboardNumber].ModelName}");          
            Console.WriteLine("\r\nNow you have to choose a processor for your gaming computer.\r\n");
            for (int i = 0; i < CPUInMemoryCollection.CPUDB.Count; i++)
            {
                if (CPUInMemoryCollection.CPUDB[i].BestResolution == chosenResolution)
                {
                    Console.Write($"Part№:{CPUInMemoryCollection.CPUDB[i].PartNumber}, ");
                    Console.Write($"Model:{CPUInMemoryCollection.CPUDB[i].Model}, ");
                    Console.Write($"Socket:{CPUInMemoryCollection.CPUDB[i].Socket}, ");
                    Console.Write($"{CPUInMemoryCollection.CPUDB[i].CoreCount}C/");
                    Console.Write($"{CPUInMemoryCollection.CPUDB[i].ThreadCount}T, ");
                    Console.Write($"Performance:{CPUInMemoryCollection.CPUDB[i].PerformanceRating} Pts, ");
                    Console.Write($"Best Resolution: {CPUInMemoryCollection.CPUDB[i].BestResolution}, ");
                    Console.Write($"Price: {CPUInMemoryCollection.CPUDB[i].Price} BGN; \r\n");
                }
            }
            Console.WriteLine($"\r\nWrite the part number of the processor that you have chosen. Its socket must be {MotherboardInMemoryCollection.MotherboardDB[chosenMotherboardNumber].Socket} and its Best Resolution must be {chosenResolution}.\r\n");

            int chosenProcessorNumber = int.Parse(Console.ReadLine()) - 1;

            while (chosenProcessorNumber < 0 || chosenProcessorNumber >= CPUInMemoryCollection.CPUDB.Count || CPUInMemoryCollection.CPUDB[chosenProcessorNumber].BestResolution != chosenResolution)
            {
                Console.WriteLine("\r\nIncorrect part number.Choose a processor from the listed above.\r\n");
                chosenProcessorNumber = int.Parse(Console.ReadLine()) - 1;
            }            
            while (CPUInMemoryCollection.CPUDB[chosenProcessorNumber].Socket != MotherboardInMemoryCollection.MotherboardDB[chosenMotherboardNumber].Socket)
            {
                Console.WriteLine($"\r\nIncorrect part number.You have chosen a processor which is not for the right socket. Please select a processor which is for {MotherboardInMemoryCollection.MotherboardDB[chosenMotherboardNumber].Socket} socket.\r\n");
                chosenProcessorNumber = int.Parse(Console.ReadLine()) - 1;
            }
            string[] processorSpecs = new string[2];
            processorSpecs[0] = CPUInMemoryCollection.CPUDB[chosenProcessorNumber].Model;
            processorSpecs[1] = CPUInMemoryCollection.CPUDB[chosenProcessorNumber].Price.ToString();

            partsMatrix[1] = processorSpecs;
        }
        private static void PrintingMotherBoardList(List<Motherboard> MotherboardDB, string[][] partsMatrix)
        {
            for (int i = 0; i < MotherboardInMemoryCollection.MotherboardDB.Count; i++)
            {
                Console.Write($"Part№:{MotherboardInMemoryCollection.MotherboardDB[i].PartNumber}, ");
                Console.Write($"Model name:{MotherboardInMemoryCollection.MotherboardDB[i].ModelName}, ");
                Console.Write($"Socket: {MotherboardInMemoryCollection.MotherboardDB[i].Socket}, ");
                Console.Write($"Price: {MotherboardInMemoryCollection.MotherboardDB[i].Price} BGN; \r\n");
            }           
            Console.WriteLine("\r\nWrite the part number of the motherboard that you have chosen.\r\n");           
        }
    }
}