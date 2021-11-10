using Inheritence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            DerivedClass instance = new DerivedClass(15, 8);

            Console.WriteLine($"Base Number = {instance._baseNumber}");
            Console.WriteLine($"Derived Field = {instance._derivedField}");

            Console.ReadKey();
        }
    }
}
