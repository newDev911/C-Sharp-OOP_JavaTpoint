using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.staticExample
{
    // Static constructor is used to initialize static fields. 
    //      > Static constructor cannot have any modifier or parameter
    //      > Static constructor is invoked implicitly. It can't be called explicitly.
    class StaticConstructorExample
    {
        public int id;
        public String name;
        public static float rateOfInterest;

        // Normal Constructor
        public StaticConstructorExample(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        // Static Constructor
        static StaticConstructorExample() // It is invoked automatically before first instance is created or any static member is referenced.
        {
            rateOfInterest = 9.5f;
        }
        public void display()
        {
            Console.WriteLine("Username: {0}", name);
            Console.WriteLine("Rate of Interest: {0}", rateOfInterest);
        }
    }
}
