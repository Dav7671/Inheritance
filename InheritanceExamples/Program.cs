using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle();
           
            // Create a myCar object
            Car myCar = new Car("Camry");
            myCar.Brand("Toyota");
            
            
            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine($"{myCar._brand} {myCar._modelName}");
            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            Console.ReadKey();
        }
    }
}
