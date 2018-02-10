using System;
using System.Collections.Generic;
using System.Text;

namespace VPShelter
{
    public class VirtualPetBase
    {

        //Create  Fields in virtualpetbase

        
        private string name = "";
        
        private string description = "";
        private bool isHungry;
        private bool isThirsty;
        private bool isBored;
        private string colorFur;
        private int age;
        private string petType;
        private string petDiet;
        





        //Create Properties in class virtualpetbase
        

        public string Name
        {
            get { return this.name; }
            set { this.name= value; }
        }


        

        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public bool IsThirsty
        {
            get { return this.isThirsty; }
            set { this.isThirsty = value; }
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

        public string PetType
        {
            get { return this.petType; }
            set { this.petType = value; }
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



        public VirtualPetBase(string name, string description, bool isHungry, bool isThirsty, bool isBored, string colorFur, int age, string petType, string petDiet)
        {
            this.name = name;

            this.description = description;
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
            this.isBored = isBored;
            this.colorFur = colorFur;
            this.age = age;
           this.petType = petType;
           this.petDiet = petDiet;
        

    }



        //Create virtual Methods() to:

        //identify type of pet
        //feed pet
        //describe pet
        //check if pet is bored        
        //change pet's fur color with user input
        //increment pet's age
        //give pet a toy with user input, this changes the value of isBored
        //define pet's diet



        //public virtual string PetName()
        //{

        //   string value = "Bear";
        //    return value;
        //}

        ////identify type of pet

        //public virtual string TypeofPet(string value)
        //{

        //    value = "Hamster";
        //    return value;
        //}



        //method to feed Pet

        //public string HungyPet()
        //{
        //    if (isHungry == true)
        //    {
        //        return "is hungry";
        //    }
        //    else return "is not hungry";
        //}


        public string FeedPet(string food)
        {
            if (food == "yes")

            {
                isHungry = false;
                return this.name + " is happy that he has been fed!";
            }
            else if (food != "yes")
                isHungry = true;
            return this.name + " is so hungry!";
        }

        //method to see if Twitch is bored

        public string BoredPet()
        {
            if (isBored == false)
            {
                return this.name + " is happy and alert!";

            }
            else
            {
                return this.name + " is very bored and is getting into mischief!";
            }
        }

        //method to change the color of the pet's fur
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
                return this.name + " now has a toy :)";
            }
            else if (toy == "no") ;
            isBored = true;
            return this.name + " has nothing to play with :(";
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


    

