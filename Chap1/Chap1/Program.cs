using System;

namespace Chap1
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIGURE 4
            // Step 3: Create an instance of the delegate type 
            // (I'll call the instance a 'delegate object') and 
            // attach (or detach) callback methods to the delegate 
            // object.
            ShipDockedCallback shipDocked = ShipOperations.Refuel;

            //FIGURE 5
            var shipDiagnostics = new ShipDiagnostics()
            {
                FuelCapacity = 100,
                FuelAvailable = 50
            };


            //FIGURE 6
            // Step 4: Invoke the delegate object (which in 
            // turn invokes all the callback methods).
            shipDocked(shipDiagnostics);

            Console.WriteLine("Operations complete!");
            Console.ReadLine();
        }

                


        }
    }

    // FIGURE 1
    //Step 1: Define the delegate type.
delegate void ShipDockedCallback(ShipDiagnostics dockingShip);


    //FIGURE 2
    class ShipOperations
    {
        // Step 2: Define callback methods whose method signature 
        // matches the the delegate type's method signature.
        public static void Refuel(ShipDiagnostics dockingShip)
        {
            Console.WriteLine("Refueling ...");
            int refuelAmount = dockingShip.FuelCapacity - dockingShip.FuelAvailable;
            if (refuelAmount > 0)
                // Implement billing system.
                // Implement robotic fueling system.
                // Reset fuel gauge:
                dockingShip.FuelAvailable = dockingShip.FuelCapacity;

            Console.WriteLine("Refueled: {0}", refuelAmount);
        }

             
    }

    //FIGURE 3
    class ShipDiagnostics
    {
        public int FuelAvailable { get; set; }
        public int FuelCapacity { get; set; }
    }
