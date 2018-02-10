using System;
using System.Collections.Generic;
using System.Text;

namespace VPShelter
{
   public class DerivedVP : VirtualPetBase
    {  //addt'l fields

        //private string petType = "";
        //private string petDiet = "";


        ////addt'l properties

        //public string PetType
        //{
        //    get { return this.petType; }
        //    set { this.petType = value; }
        //}

        //public string PetDiet
        //{
        //    get { return this.petDiet; }
        //    set { this.petDiet = value; }
        //}

        public DerivedVP()
        {
            //default constructor
        }


        //public DerivedVP(string name,  string petType)
        //{
        //    Name = name;
        //    PetType = petType;

        //}
        public DerivedVP(string name, string petType, string description, bool isHungry, bool isThirsty, bool isBored, string colorFur, int age, string petDiet)
        {
            Name = name;
            PetType = petType;
            Description = description;
            IsHungry = isHungry;
            IsThirsty = isThirsty;
            IsBored = isBored;
            ColorFur = colorFur;
            Age = age;
            PetDiet = petDiet;

        }

        //methods

        public void HungryPet()
        {
            
            if (IsHungry == true)
            {

                Console.WriteLine("is hungry");
            }
            else Console.WriteLine("is not hungry");
        }

        public void ThirstyPet()
        {

            if (IsThirsty == true)
            {

                Console.WriteLine("is thirsty");
            }
            else Console.WriteLine("is not thirsty");
        }


    }
}
