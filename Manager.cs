using System;
using System.Collections.Generic;
using System.Text;

namespace VPShelter
{
    public class Manager : Employee
    {
        // fields
        private bool adoptAPet;

        //properties

        public bool AdoptAPet        
        {
            get { return this.adoptAPet; }
            set { this.adoptAPet = value; }
        }

        public Manager()
        {
            //default constructor

        }

        public Manager (bool adoptAPet)
        {
            this.adoptAPet = adoptAPet;
        }

        //methods

        public void FeedAllPets()
        {
            Console.WriteLine("All the pets have been fed.");
        }

        public void WaterAllPets()
        {
            Console.WriteLine("All of the pets have been given water.");
        }

        public override void GetEmployeeSalary()
        {
            Console.WriteLine("You make $25,000 a year.");
        }

        


        public override void Quit()
        {
            Console.WriteLine("Sorry, you can't quit- you have a contract!");
        }


        public string PetAdoption(string answer)
        {
            if (answer == "bear")
            {
                return "Congratulations! You've adopted a hamster!";
            }
            else if (answer == "shanty")
            {
                return "Congratulations, You've adopted a cat!";
            }
            else return "Maybe next time.";
        } 




    }
}
