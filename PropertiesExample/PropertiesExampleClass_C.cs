using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.PropertiesExample
{
    class PropertiesExampleClass_C
    {
        private static int counter;

        public PropertiesExampleClass_C()
        {
            counter++;
        }

        public static int Counter
        {
            get
            {
                return counter;
            }
        }
    }
}
