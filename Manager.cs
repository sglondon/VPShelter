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
            if (answer == "Bear")
            {
                return "Congratulations! You've adopted a hamster!";
            }
            else if (answer == "Shanty")
            {
                return "Congratulations, You've adopted a cat!";
            }
            else return "Maybe next time.";
        } 




    }
}
