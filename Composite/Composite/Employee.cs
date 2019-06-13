using System;
using System.Collections.Generic;
using System.Text;

/*Component -- This is represented by either an abstract class or an interface and serves as the base type for all objects in the hierarchy*/

/*
 Consider the following class, named Employee. This is an abstract class and represents the "Component" in this design.
 It contains abstract methods to add, an employee, remove an employee and also get data related to one or more employees.
 The abstract class Employee also contains an argument constructor to assign values to the name and salary variables.     
*/
namespace Composite
{
    abstract class Employee
    {
        protected string name;

        protected double salary;

        protected Employee(string name,double salary)
        {
            this.name = name;
            this.salary = salary;
        }


        public abstract void Add(Employee emp);

        public abstract void Remove(Employee emp);


        public abstract string GetData();


    }
}
