using System;
using System.Collections.Generic;
using System.Text;

namespace VPShelter
{
    public class VirtualPetBase
    {

        //Create  Fields in virtualpetbase

        
        private string name = "";
        private string petType = "";
        private string description = "";
        private bool isHungry;
        private bool isThirsty;
        private bool isBored;
        private string colorFur;
        private int age;
        private string petDiet = "";





        //Create Properties in class virtualpetbase
        

        public string Name
        {
            get { return this.name; }
            set { this.name= value; }
        }


        public string PetType
        {
            get { return this.petType; }
            set { this.petType = value; }
        }

        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public string IsThirsty
        {
            get { return this.IsThirsty; }
            set { this.IsThirsty = value; }
        }


        public bool IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value; }
        }

        public string ColorFur
        {
            get { return this.colorFur; }
            set { this.colorFur = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public string PetDiet
        {
            get { return this.petDiet; }
            set { this.petDiet = value; }
        }

        //Create Constructors

        public VirtualPetBase()
        {
            //default constructor
        }

        public VirtualPetBase(string name, string description)
        {

            this.name = name;
            this.description = description;
        }



        public VirtualPetBase(string name, string petType, string description, bool isHungry, bool isThirsty, bool isBored, string colorFur, int age, string petDiet)
        {
            this.name = name;
            this.petType = petType;
            this.description = description;
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
            this.isBored = isBored;
            this.colorFur = colorFur;
            this.age = age;
            this.petDiet = petDiet;


        }



        //Create Methods() to:
        // display pet's name
        //feed pet
        //check if pet is bored        
        //change pet's fur color with user input
        //increment pet's age
        //give pet a toy with user input, this changes the value of isBored



        public void BunnyName()
        {

            Console.WriteLine("Your Bunny's name is Twitch!");
        }


        //method to feed Twitch


        public string FeedTwitch(string food)
        {
            if (food == "yes")

            {
                isHungry = false;
                return "Twitch is happy that he has been fed!";
            }
            else if (food != "yes")
                isHungry = true;
            return "Twitch is so hungry!";
        }

        //method to see if Twitch is bored

        public string BoredBunny()
        {
            if (isBored == false)
            {
                return "Twitch is happy and alert!";

            }
            else
            {
                return "Twitch is very bored and is getting into mischief!";
            }
        }

        //method to change the color of Twitch's fur
        //using user input

        public string FurChange(string newFur)
        {
            this.colorFur = newFur;
            return newFur;

        }

        //method to change the value of isBored
        //by giving the pet a toy

        public string GiveToy(string toy)
        {
            if (toy == "yes")
            {
                isBored = false;
                return "Twitch now has a ball :)";
            }
            else if (toy == "no") ;
            isBored = true;
            return "Twitch has nothing to play with :(";
        }

        //method to increment age

        public void ChangeAge()
        {
            this.age = ++age;
        }

        //method to display a message

        public void Message()
        {

            string[] wheresBunny = new string[]
            {
                "What woud ",
                "you like  ",
                "to do?"
            };
            //foreach (string value in wheresBunny)
            //{
            //    Console.Write(value);
            //}

        }

        

        





    }
}


    

