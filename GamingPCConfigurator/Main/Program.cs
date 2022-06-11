using GamingPCConfigurator.DL.InMemoryDB;
using System;

namespace GamingPCConfigurator.Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[][] partsMatrix = new string[8][];
            Console.WriteLine("Welcome to the GamingPCConfigurator");
            Console.WriteLine("What is your desired resolution for playing games ?");
            Console.WriteLine("Please choose from the following: FHD, 2K or 4K and write your preference");

            string chosenResolution = Console.ReadLine().ToUpper();
            if (chosenResolution != "FHD" && chosenResolution != "2K" && chosenResolution != "4K")
            {
                Console.WriteLine("Wrong resolution. Try again with one of the following: FHD, 2K or 4K");
                chosenResolution = Console.ReadLine();
            }
            Console.WriteLine($"Is your preferred resolution {chosenResolution}?. Write YES if it is or NO if you want to switch it");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "NO")
            {
                Console.WriteLine("Please choose from the following: FHD, 2K or 4K and write your preference");
                chosenResolution = Console.ReadLine().ToUpper();
                while (chosenResolution != "FHD" && chosenResolution != "2K" && chosenResolution != "4K")
                {
                    Console.WriteLine("Wrong resolution. Try again with one of the following: FHD, 2K or 4K");
                    chosenResolution = Console.ReadLine().ToUpper();
                }
            }
            Console.WriteLine($"You have chosen {chosenResolution}.We will offer you parts which are good for gaming at this resolution. \r\n");

            Console.WriteLine("First you have to choose a motherboard for your gaming computer. \r\n");

            for (int i = 0; i < MotherboardInMemoryCollection.MotherboardDB.Count; i++)
            {
                Console.Write($"{MotherboardInMemoryCollection.MotherboardDB[i].PartNumber} ");
                Console.Write($"{MotherboardInMemoryCollection.MotherboardDB[i].ModelName} ");
                Console.Write($"Socket: {MotherboardInMemoryCollection.MotherboardDB[i].Socket} ");
                Console.Write($"RAM Slots: {MotherboardInMemoryCollection.MotherboardDB[i].RAMSlots} ");
                Console.Write($"Price: {MotherboardInMemoryCollection.MotherboardDB[i].Price} ");
                Console.WriteLine();
            }
            Console.WriteLine("Write the Part number of the motherboard that you have chosen.");
            int chosenMotherboardNumber = int.Parse(Console.ReadLine()) - 1;

            string[] motherboardSpecs = new string[5];

            motherboardSpecs[0] = MotherboardInMemoryCollection.MotherboardDB[chosenMotherboardNumber].PartNumber.ToString();
            motherboardSpecs[1] = MotherboardInMemoryCollection.MotherboardDB[chosenMotherboardNumber].ModelName.ToString();
            motherboardSpecs[2] = MotherboardInMemoryCollection.MotherboardDB[chosenMotherboardNumber].Socket;
            motherboardSpecs[3] = MotherboardInMemoryCollection.MotherboardDB[chosenMotherboardNumber].RAMSlots.ToString();
            motherboardSpecs[4] = MotherboardInMemoryCollection.MotherboardDB[chosenMotherboardNumber].Price.ToString();                   
            partsMatrix[0] = motherboardSpecs;

            Console.WriteLine("Now you have to choose a processor for your gaming computer. \r\n");
            
            for( int i = 0; i < CPUInMemoryCollection.CPUDB.Count; i++ )
            {
                Console.Write($"{CPUInMemoryCollection.CPUDB[i].PartNumber}, ");
                Console.Write($"{CPUInMemoryCollection.CPUDB[i].Model}, ");
                Console.Write($"Socket: {CPUInMemoryCollection.CPUDB[i].Socket}, ");
                Console.Write($"Cores: {CPUInMemoryCollection.CPUDB[i].CoreCount}, ");
                Console.Write($"Threads: {CPUInMemoryCollection.CPUDB[i].ThreadCount}, ");
                Console.Write($"Performance Rating:{CPUInMemoryCollection.CPUDB[i].PerformanceRating}, ");
                Console.Write($"Best Resolution: {CPUInMemoryCollection.CPUDB[i].BestResolution}, ");
                Console.Write($"Price: {CPUInMemoryCollection.CPUDB[i].Price}; ");
                Console.WriteLine();
            }
            Console.WriteLine($"Write the Part number of the processor that you have chosen. Its socket must be {motherboardSpecs[2]} and we recommend that its BestResolution is {chosenResolution}.");
            int chosenProcessorNumber = int.Parse(Console.ReadLine()) - 1;

            if (CPUInMemoryCollection.CPUDB[chosenProcessorNumber].Socket != MotherboardInMemoryCollection.MotherboardDB[chosenMotherboardNumber].Socket)
            {
                Console.WriteLine($"You have chosen a processor which is not for the right socket. Please select a processor which is for {motherboardSpecs[2]} socket");
                chosenProcessorNumber = int.Parse(Console.ReadLine()) - 1;
            }

            string[] processorSpecs = new string[10];

            processorSpecs[0] = CPUInMemoryCollection.CPUDB[chosenProcessorNumber].PartNumber.ToString();
            processorSpecs[1] = CPUInMemoryCollection.CPUDB[chosenProcessorNumber].ManufacturerName;
            processorSpecs[2] = CPUInMemoryCollection.CPUDB[chosenProcessorNumber].Model;
            processorSpecs[3] = CPUInMemoryCollection.CPUDB[chosenProcessorNumber].Socket;
            processorSpecs[4] = CPUInMemoryCollection.CPUDB[chosenProcessorNumber].PerformanceRating.ToString();
            processorSpecs[5] = CPUInMemoryCollection.CPUDB[chosenProcessorNumber].BestResolution;
            processorSpecs[6] = CPUInMemoryCollection.CPUDB[chosenProcessorNumber].CoreCount.ToString();
            processorSpecs[7] = CPUInMemoryCollection.CPUDB[chosenProcessorNumber].ThreadCount.ToString();
            processorSpecs[8] = CPUInMemoryCollection.CPUDB[chosenProcessorNumber].PowerDraw.ToString();          
            processorSpecs[9] = CPUInMemoryCollection.CPUDB[chosenProcessorNumber].Price.ToString();
            partsMatrix[1] = processorSpecs;
        }
    }
}