using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample2
{
    class Details : User
    {
        public int age;
        public Details()
        {
       
        }
        public void GetAge()
        {
            Console.WriteLine("age: {0}", age);
        }
    }
}
