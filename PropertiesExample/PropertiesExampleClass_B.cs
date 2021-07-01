using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.PropertiesExample
{
    // Having logic while setting values
    class PropertiesExampleClass_B
    {
        public string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = "Employee Name: " + value;
            }
        }
    }
}
