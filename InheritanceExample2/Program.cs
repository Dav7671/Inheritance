using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Details _details = new Details();
            _details.name = "Davit Margaryan";
            _details.mail = "davo@mail.com";
            _details.age = 20;
            _details.GetUserInfo();
            _details.GetAge();

            Console.ReadKey();
        }
    }
}
