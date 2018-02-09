using System;
using System.Collections.Generic;
using System.Text;

namespace VPShelter
{
    class DerivedVP : VirtualPetBase
    {
        

        public DerivedVP()
        {
            //default constructor
        }

        public DerivedVP(string name, string petType, string description, bool isHungry, bool isThirsty, bool isBored, string colorFur, int age, string petDiet)
        {
            this.Name = name;
            this.PetType = petType;
            this.Description = description;
            this.IsHungry = isHungry;
          //  this.IsThirsty = isThirsty;
            this.IsBored = isBored;
            this.ColorFur = colorFur;
            this.Age = age;
            this.PetDiet = petDiet;

        }

    }
}
