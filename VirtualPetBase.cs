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
        private string isHungry;
        private string isThirsty;
        private string isBored = "";
        private string colorFur;
        private int age;




        //Create Properties in class virtualpetbase


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        public string IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public string IsThirsty
        {
            get { return this.isThirsty; }
            set { this.isThirsty = value; }
        }


        public string IsBored
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



        public VirtualPetBase(string name, string description, string isHungry, string isThirsty, string isBored, string colorFur, int age)
        {
            this.name = name;
            this.description = description;
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
            this.isBored = isBored;
            this.colorFur = colorFur;
            this.age = age;


        }


























    }
}




