using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AbstractFactory!");
            // Create and run the African animal world

            LabActionsFactory labActionsFactory = new GCALFactory();
            LABWorld world = new LABWorld(labActionsFactory);

            world.RunAcions();

            // Wait for user input

            Console.ReadKey();
        }
    }
}
