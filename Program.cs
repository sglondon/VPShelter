using System;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;

            //instantiate virtualpetbase object

            DerivedVP hamster = new DerivedVP("Bear", "Hamster", "funny little guy", true, true, true, "orange & white", 1, "sunflower seeds");

            DerivedVP cat = new DerivedVP("Shanty", "Cat", "short hair, happy cat", false, false, false, "black & white", 2, "tuna");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("To see your pet's name, type 1");
            Console.WriteLine("To see what type of pet you have, type 2");
            Console.WriteLine("To feed your pet, type 2");
            Console.WriteLine("To see if your pet needs some attention, type 3");
            Console.WriteLine("To see how old your pet is, type 4");
            Console.WriteLine("To see what color fur your pet has, type 5");
            Console.WriteLine("To see your bunny's details, type 6");
            Console.WriteLine("To change the color of your pet's fur, type 7");
            Console.WriteLine("To play with your pet, type 8");
            Console.WriteLine("To quit, type 9");
            userChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            switch (userChoice)
            {
                case 1:
                    
                    Console.WriteLine("Your pet's name is " + hamster.Name + ".");
                    break;

                case 2:
                    Console.WriteLine("Your pet is a " + hamster.PetType + ".");
                    break;

            //    case 3:
            //        Console.WriteLine();
            //        Console.WriteLine("Would you like to give " + hamster.Name + " some food? Please type yes or no");
            //        string food = Console.ReadLine();
            //        Console.WriteLine(hamster.FeedPet(food));
            //        break;

            //    case 3:
            //        Console.WriteLine(userBunny.BoredBunny());
            //        break;

            //    case 4:
            //        Console.WriteLine(userBunny.Name + " is " + userBunny.Age + " years old.");
            //        break;

            //    case 5:
            //        Console.WriteLine(userBunny.Name + " has " + userBunny.ColorFur + " fur.");
            //        break;

            //    case 6:
            //        Console.WriteLine();
            //        Console.WriteLine();
            //        Console.WriteLine("Your Bunny's name is " + userBunny.Name);
            //        Console.WriteLine(userBunny.FeedTwitch("yes"));
            //        Console.WriteLine(userBunny.BoredBunny());
            //        Console.WriteLine(userBunny.Name + " is " + userBunny.Age + " years old.");
            //        Console.WriteLine(userBunny.Name + " has " + userBunny.ColorFur + " fur.");
            //        break;

            //    case 7:
            //        Console.WriteLine();
            //        Console.WriteLine(userBunny.Name + " has " + userBunny.ColorFur + " fur.");
            //        Console.WriteLine();
            //        Console.WriteLine("What color would you like to make Twitch's fur?, please enter a color.");
            //        string newFur = Console.ReadLine();
            //        Console.WriteLine();
            //        Console.WriteLine("Twitch's fur is now " + userBunny.FurChange(newFur) + " !");
            //        break;

            //    case 8:
            //        Console.WriteLine();
            //        Console.WriteLine("Would you like to give Twitch a toy? Please type yes or no");
            //        string toy = Console.ReadLine();
            //        Console.WriteLine(userBunny.GiveToy(toy));
            //        break;
            //}

        } while (userChoice != 0);


        }






}
    }

//}
