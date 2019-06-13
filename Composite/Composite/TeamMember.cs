using System;
using System.Collections.Generic;
using System.Text;

/*
 The last class in our design is the TeamMember class that represents the leaf node in the composite structure. Here's how this class looks:
 */

/*
 A leaf node in a composite structure doesn’t have any children, right? Note that since the TeamMember class represents a leaf node in the composite structure,
 there are no implementations of the “Add” or the “Remove” methods in this class.
 */

namespace Composite
{
    class TeamMember : Employee
    {
        public TeamMember(string name, double salary) : base(name, salary) { }
        public override void Add(Employee employee)

        {

            //Operation not permitted since this is a leaf node.

        }

        public override void Remove(Employee employee)

        {

            //Operation not permitted since this is a leaf node.

        }

        public override string GetData()

        {

            return "Name: " + name + "\tSalary: " + salary.ToString("N2");

        }
    }
}
