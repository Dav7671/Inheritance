using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class DerivedClass : BaseClass
    {

        public int _derivedField;

        /// <summary>
        /// custom constructor
        /// </summary>
        /// <param name="number1">given number1 of Int32 type</param>
        /// <param name="number2">given number2 of Int32 type</param>

        public DerivedClass(int number1, int number2) : base(number1)
        {
            _derivedField = number2;

            //  _baseNumber = number1
        }

        public DerivedClass()
        {

        }

    }
}
