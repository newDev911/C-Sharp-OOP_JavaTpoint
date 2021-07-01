using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.Constructor_Destructor
{
    // Whenever you inherit the base class, bass class constructor in internally invoked.
    public class ConstructorWithInheritance_Animal
    {
        public ConstructorWithInheritance_Animal()
        {
            Console.WriteLine("Animal Class - Parent");
        }
    }

    public class ConstructorWithInheritance_Cat:ConstructorWithInheritance_Animal
    {
        public ConstructorWithInheritance_Cat()
        {
            Console.WriteLine("Cat Class - Child");
        }
    }
}
