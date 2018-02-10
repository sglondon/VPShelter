using System;
using System.Collections.Generic;
using System.Text;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        //field

        private bool cleanCage;
        
        
        public bool CleanCage
        {
            get { return this.cleanCage; }
            set { this.cleanCage = value; }
        }

        //constructor

            public Volunteer (bool CleanCage)
        {
            this.cleanCage = cleanCage;
            
        }

        public override void GetEmployeeSalary()
        {
            Console.WriteLine("You're a volunteer, you don't get any salary!");
        }


        public void IsClean()
        {
            if( CleanCage == true)
            {
                Console.WriteLine("The cages are clean");
            }
            else if (CleanCage != true)
            {
                Console.WriteLine("The cages have been cleaned.");
            }
        }

        public void Message()
        {
            Console.WriteLine("What would you like to do next?");

        }



        public override void Quit()
        {
            Console.WriteLine("Thanks for your help today!.");
        }



        public void FeedAllPets()
        {
            Console.WriteLine("All the pets have been fed.");
        }

        public void WaterAllPets()
        {
            Console.WriteLine("All of the pets have been given water.");
        }



    }

}
