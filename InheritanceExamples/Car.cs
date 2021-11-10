using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    class Car : Vehicle  // derived class (child)
    {
        public string _modelName;

        public Car(string name)
        {
            _modelName = name;
        }
    }
}
