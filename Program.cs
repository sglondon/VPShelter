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

            //instantiate  objects            

            DerivedVP hamster = new DerivedVP("Bear", "Hamster", "funny little guy", "is not hungry", "is not thirsty", "is bored", "orange and white", 1, "sunflower seeds");
            DerivedVP cat = new DerivedVP("Shanty", "Cat", "short hair, happy cat", "is hungry", "is thirsty", "is not bored", "black & white", 2, "tuna");
            Volunteer emp1 = new Volunteer(true);
            Manager emp2 = new Manager(true);

            //start menu

            do
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to the Virtual Pet Shelter.");
                Console.WriteLine("What type of employee are you?");
                Console.WriteLine("1. Volunteer");
                Console.WriteLine("2. Manager");
                Console.WriteLine("3. Exit");
                userChoice = int.Parse(Console.ReadLine());


                if (userChoice == 1)
                {


                    Console.WriteLine("Thank you for volunteering at the Virtual Pet Shelter!");
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Hi Volunteer!");
                    Console.WriteLine("Here is the status of the pets today:");
                    Console.WriteLine();
                    Console.WriteLine(hamster.Name + " the " + hamster.PetType + ":" + "\n" + hamster.IsHungry + ", " + hamster.IsThirsty + "," + " and is " + hamster.IsBored + ".");
                    Console.WriteLine();
                    Console.WriteLine(cat.Name + " the " + cat.PetType + "\n" + cat.IsHungry + ", " + cat.IsThirsty + ", " + " and is " + cat.IsBored + ".");
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do?");

                    do
                    {
                        Console.WriteLine("1. Feed the pets");
                        Console.WriteLine("2. Give the pets water");
                        Console.WriteLine("3. Clean the pet cages");
                        Console.WriteLine("4. Play with the pets");
                        Console.WriteLine("5. See your salary information");
                        Console.WriteLine("6. Quit");

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
                                Console.Clear();
                                emp1.GetEmployeeSalary();
                                Console.WriteLine();
                                emp1.Message();
                                break;


                            case 6:
                                emp1.Quit();
                                userChoice = 6;
                                break;
                        }

                    } while (userChoice != 6);

                }


                else if (userChoice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for coming to work today!");
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do?");


                    do
                    {
                        Console.WriteLine("1. Feed the pets");
                        Console.WriteLine("2. Give the pets water");
                        Console.WriteLine("3. Arrange a pet adoption");
                        Console.WriteLine("4. See your salary information");
                        Console.WriteLine("5. Quit");

                        userChoice = int.Parse(Console.ReadLine());

                        switch (userChoice)
                        {
                            case 1:
                                Console.Clear();
                                //   Console.WriteLine(hamster.Name + " the " + hamster.PetType + " likes to eat " + hamster.PetDiet + ".");
                                Console.WriteLine();
                                //   Console.WriteLine(cat.Name + " the " + cat.PetType + " likes to eat " + cat.PetDiet + ".");
                                Console.WriteLine();
                                emp2.FeedAllPets();
                                Console.WriteLine();
                                emp1.Message();

                                break;

                            case 2:
                                Console.Clear();
                                emp2.WaterAllPets();
                                Console.WriteLine();
                                emp1.Message();
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("Which pet would you like to adopt, Bear or Shanty?");
                                string answer = Console.ReadLine().ToLower();
                                Console.WriteLine(emp2.PetAdoption(answer));
                                Console.WriteLine();
                                Console.Clear();
                                if (answer == "bear")
                                {
                                    Console.WriteLine("You adopted a " + hamster.PetType + " named " + hamster.Name + ":" + "\n" + "he has " + hamster.ColorFur + " color fur, his favorite food is " + hamster.PetDiet + " and he is a " + hamster.Description + "!");

                                }

                                else if (answer == "shanty")
                                {
                                    Console.WriteLine("You've adopted a " + cat.PetType + " named " + cat.Name + ":" + "\n" + "he has " + cat.ColorFur + " color fur, his favorite food is " + cat.PetDiet + " and he is a " + cat.Description + "!");

                                }

                                Console.WriteLine();


                                emp1.Message();

                                break;

                            case 4:
                                Console.Clear();
                                emp2.GetEmployeeSalary();
                                Console.WriteLine();
                                emp1.Message();
                                break;

                            case 5:
                                Console.Clear();
                                emp2.Quit();
                                userChoice = 5;
                                break;
                        }

                    } while (userChoice != 5);
                }

                else if (userChoice == 3) ;
                    {
                        Console.WriteLine("Thanks for visiting the Virtual Pet Shelter");
                    Console.Clear();
                    }

                } while (userChoice != 3) ;
            }
            }
            }
        



    







