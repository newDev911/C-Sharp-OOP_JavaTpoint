using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.InhertanceExample
{
    // MULTI-LEVEL INHERITANCE:
        // When one class inherits another class which is further inherited by another class, it is known as Multi-Level Inheritance
    //      Inheritance is transative, so the last derived class aquires all the members of all its bases class.
    class InheritanceExampleB_Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class InheritanceExampleB_Dog : InheritanceExampleB_Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    class InheritanceExampleB_BabyDog : InheritanceExampleB_Dog
    {
        public void weep()
        {
            Console.WriteLine("Weeping...");
        }
    }
}
