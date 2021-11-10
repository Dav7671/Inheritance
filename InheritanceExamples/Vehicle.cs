using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    class Vehicle  // base class
    {
        public string _brand;  // Vehicle field    
       
        public void Brand(string brand)
        {
            _brand = brand;
        }
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Brrr !!");
        }
    }
}

