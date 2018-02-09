using System;
using System.Collections.Generic;
using System.Text;

namespace VPShelter
{
    public class Volunteer : Employee
    {

        
        
        public bool CleanCage { get; set; }


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
