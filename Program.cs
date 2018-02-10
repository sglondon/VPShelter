using System;

using System.Collections.Generic;
using System.Text;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;

            //instantiate virtualpetbase object


      //      DerivedVP hamster = new DerivedVP("Bear", "Hamster");

           DerivedVP hamster = new DerivedVP("Bear", "Hamster", "funny little guy", "is not hungry", "is not thirsty", "is bored", "orange and white", 1, "sunflower seeds");       
           DerivedVP cat = new DerivedVP("Shanty", "Cat", "short hair, happy cat", "is hungry", "is thirsty", "is not bored", "black & white", 2, "tuna");
            Volunteer emp1 = new Volunteer(true);
                
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome to the Virtual Pet Shelter.");
            Console.WriteLine("What type of employee are you?");
            Console.WriteLine("1. Volunteer");
            Console.WriteLine("2. Manager");
            userChoice = int.Parse(Console.ReadLine());
            
                                
            switch (userChoice)
            {
                case 1:
                    
                    Console.WriteLine("Thank you for volunteering at the Virtual Pet Shelter!");
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Hi Volunteer!");
                    Console.WriteLine("Here is the status of the pets today:");
                    Console.WriteLine();
                    Console.WriteLine(hamster.Name + " the "+ hamster.PetType + ":" +"\n" + hamster.IsHungry + ", " + hamster.IsThirsty + "," + hamster.IsBored + ".");
                    Console.WriteLine();
                    Console.WriteLine(cat.Name + " the " + cat.PetType + "\n" + cat.IsHungry + ", " + cat.IsThirsty + ", " + cat.IsBored + ".");
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do with the pets?");

                    do
                    {   
                        Console.WriteLine("1. Feed the pets");
                        Console.WriteLine("2. Give the pets water");
                        Console.WriteLine("3. Clean the pet cages");
                        Console.WriteLine("4. Play with the pets");
                        Console.WriteLine("5. Quit");
                        
                        userChoice = int.Parse(Console.ReadLine());

                        switch (userChoice)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine(hamster.Name + " the " + hamster.PetType + " likes to eat " + hamster.PetDiet + ".");
                                Console.WriteLine();
                                Console.WriteLine(cat.Name + " the " + cat.PetType + " likes to eat " + cat.PetDiet + ".");
                                Console.WriteLine();
                                emp1.FeedAllPets();                                
                                Console.WriteLine();
                                emp1.Message();
                                
                                break;

                            case 2:
                                Console.Clear();
                                emp1.WaterAllPets();
                                Console.WriteLine();
                                emp1.Message();
                                break;

                            case 3:
                                Console.Clear();
                                emp1.IsClean();
                                Console.WriteLine();
                                emp1.Message();
                                break;

                            case 4:
                                Console.Clear();
                                Console.WriteLine("Which pet would you like to play with, Bear or Shanty?");
                                string pet = Console.ReadLine().ToUpper();
                                Console.Clear();
                                Console.WriteLine(emp1.GiveToy(pet));
                                Console.WriteLine();                                
                                emp1.Message();
                                break;

                            case 5:
                                emp1.Quit();
                                userChoice = 5;
                                break;
                        }
                        
                    } while (userChoice != 5) ;
                    break;
                    
                    
                    

                case 2:
                    Console.WriteLine("Thanks for coming to work today!");

                    break;











                    //{
                    //    case 1:

                    //        Console.WriteLine("Your pet's name is " + hamster.Name + ".");
                    //        break;

                    //    case 2:
                    //        Console.WriteLine("Your pet is a " + hamster.PetType + ".");
                    //        break;

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

                    //  } while (userChoice != 0);







            }

        }
    }
}

