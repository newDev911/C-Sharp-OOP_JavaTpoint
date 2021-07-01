using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.PropertiesExample
{
    // C# properties doesn't have storage location. C# properties are extension of fields and accessed like fields.
    // USAGE:
    //      > Properties can be read-only or write-only.
    //      > We can have logic while setting values in the C# properties
    //      > We make fields of class 'private', so that fields can't be accessed outside the class.
    //      > Now we are forced to C# properties for getting or setting values.

    // Getter, Setter Example
    class PropertiesExampleClass_A
    {
        private string name;

        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
