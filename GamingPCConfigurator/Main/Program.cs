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


        }
    }
}