using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.Polymorphism
{
    // METHOD OVERRIDING:
    //      If derived class defines same method as defined in its Base class, it is known as Method Overriding.
    //      It is used to achieve runtime Polymorphism. It enables you to provide specific implementation of the method which is already provided by its Base class.

    // * To perform method overriding you need to use 'virtual' keyword with Base class method & 'override' keyword with derived class method
    class MethodOverridingExample_Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating");
        }
    }

    class MethodOverridingExample_Goat : MethodOverridingExample_Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating Bread...");
        }
    }
}
