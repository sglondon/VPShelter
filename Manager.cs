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

        //override methods

        public override void GetEmployeeSalary()
        {
            Console.WriteLine("You make $25,000 a year.");
        }

        
        
        public override void Quit()
        {
            Console.WriteLine("Sorry, you can't quit- you have a contract, haha!");
        }

        //adopt a pet method

        public string PetAdoption(string answer)
        {
            if ((answer == "bear") || (answer == "shanty"))
            {
                return "Congratulations! Here are some details about your new pet:";
            }
            else return "";
        } 




    }
}
