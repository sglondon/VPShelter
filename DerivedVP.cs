﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VPShelter
    //addt'l fields
{
   public class DerivedVP : VirtualPetBase
    {  

        private string petType = "";
        private string petDiet = "";


        //addt'l properties

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

        //constructors

        public DerivedVP()
        {
            //default constructor
        }


        
        public DerivedVP(string name, string petType, string description, string isHungry, string isThirsty, string isBored, string colorFur, int age, string petDiet)
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

        

       


    }
}
