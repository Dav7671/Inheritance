using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002Inheritance
{
    class DerivedClass : BaseClass
    {
        private string publicField;
        private string protectedField;

        public DerivedClass()
        {
            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";

        }
    }
}
