using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class BaseClass
    {
       

        public int _baseNumber;


        /// <summary>
        /// deffault constructor
        /// </summary>
      
        public BaseClass()
        {

        }

        /// <summary>
        /// custom constructor
        /// </summary>
        /// <param name="baseNumber">given base number of Int32 type</param>

        public BaseClass(int baseNumber)
        {
            _baseNumber = baseNumber;
        }

    
    }
}
