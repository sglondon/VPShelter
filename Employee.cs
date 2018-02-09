using System;
using System.Collections.Generic;
using System.Text;

namespace VPShelter
{
    public abstract class Employee
    {
        //invisible fields

        //properties

        public string EmployeeID { get; set; }


        //abstract methods

        public abstract void GetEmployeeSalary();
        public abstract void Quit();













    }

}
