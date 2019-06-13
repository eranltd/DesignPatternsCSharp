using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeA = new TeamMember("Joydip Kanjilal", 20000);

            Employee employeeB = new TeamMember("Samuel Jones", 45000);

            Employee teamLead = new TeamLeader("Steve Smith", 75000);

            teamLead.Add(employeeA);

            teamLead.Add(employeeB);

            Console.WriteLine(teamLead.GetData());
            Console.WriteLine(teamLead.GetData());



            Console.Read();

        }
    }
}
