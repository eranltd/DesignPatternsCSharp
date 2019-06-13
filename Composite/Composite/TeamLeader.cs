using System;
using System.Collections.Generic;
using System.Text;

/*
 The next class in our design is named "TeamLead" and it represents the "Composite" type in our design,
 extends the Employee class, and provides the definition for the abstract methods.
 */

namespace Composite
{
    class TeamLeader : Employee
    {
        List<Employee> lstEmployee = new List<Employee>();

        public TeamLeader(string name,double salary) : base(name, salary) { }
        public override void Add(Employee employee)

        {

            lstEmployee.Add(employee);

        }

        public override void Remove(Employee employee)

        {

            lstEmployee.Remove(employee);

        }

        public override string GetData()

        {

            StringBuilder sbEmployee = new StringBuilder();

            foreach (Employee emp in lstEmployee)

            {

                sbEmployee.Append(emp.GetData() + "\n");

            }

            return sbEmployee.ToString();

        }
    }
}
