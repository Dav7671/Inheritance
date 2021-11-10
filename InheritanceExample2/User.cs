using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample2
{
    public class User
    {
        public string name;
        public string mail;

        public User()
        {

        }

        public void GetUserInfo()
        {
            Console.WriteLine($"Name:  {name}");
            Console.WriteLine($"Mail:  {mail}");
        }
    }
}
