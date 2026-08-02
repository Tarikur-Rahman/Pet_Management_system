using System;


namespace Pet_Management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            string? readResult = "";
            string animalSpecies = "";
            string animalId = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";
            int petCount = 0;

            bool exit = false;
            do
            {
                Console.WriteLine("\n\r Enter 'Dog' or 'Cat' to begin a new entry");
                readResult = Console.ReadLine();

                if(readResult != null)
                {
                    animalSpecies = readResult.ToLower();
                
                    if(animalSpecies != "dog" && animalSpecies != "cat")
                    {
                        exit = false;
                    }else
                    {
                        exit =true;
                    }
                }
            }while(exit == false);
            animalId = animalSpecies.Substring(0,1) + (petCount + 1).ToString();
            do
            {
                int petAge;

                Console.WriteLine("Enter the pet's age or enter ? if umknown");
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                    animalAge = readResult;
                }
                if(animalAge != "?")
                {
                    exit = int.TryParse(animalAge, out petAge);
                }else
                {
                    exit = true;
                }
            }while(exit == false);

            do
            {
                Console.WriteLine("Enter a Physical description of the pet (size, color, gender, weight, housebroken,)");
                readResult = Console.ReadLine();

                if(readResult != null)
                {
                    animalPhysicalDescription = readResult.ToLower();
                }
                if(animalPhysicalDescription == "")
                {
                    animalPhysicalDescription = "tbd";
                }
            }while(animalPhysicalDescription == "");

            do
            {
                Console.WriteLine("Enter a description of the pet's personality (like or deslike, tricks, energy level)");
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                   animalPersonalityDescription = readResult.ToLower(); 
                }
                if(animalPersonalityDescription == "")
                {
                    animalPersonalityDescription = "tbd";
                }
            }while(animalPersonalityDescription == "");
            
            do
            {
                Console.WriteLine("Enter a nickname for the pet");
                readResult = Console.ReadLine();
                if(readResult != null)
                {
                   animalNickname = readResult.ToLower(); 
                }
                if(animalNickname == "")
                {
                    animalNickname = "tbd";
                }
            }while(animalNickname == "");
            string[,] ourAnimals = new string[8,6];
            ourAnimals[petCount, 0] = "ID #: " + animalId;
            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
            ourAnimals[petCount, 2] = "Age: " + animalAge;
            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
            ourAnimals[petCount, 4] = "Physical Description: " + animalPhysicalDescription;
            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

            Console.WriteLine("\n\n");
            Console.WriteLine("=====================================================");
            Console.WriteLine("Animal Information:");
            Console.WriteLine();
            foreach (string animal in ourAnimals)
            {
                if(animal != null)
                {
                    Console.WriteLine(animal);
                }
            }
            Console.WriteLine("=====================================================");
        }
    }
}