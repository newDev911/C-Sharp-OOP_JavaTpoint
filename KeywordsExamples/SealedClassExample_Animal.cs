using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
// Sealed Class:
    Sealed class applies restrictions on the class and methods.
     >  Sealed class cannot be derived
     >  Sealed method cannot be overridden.
*/
namespace CSharpOOP_JavaTpoint.KeywordsExamples
{
    // Add 'sealed' before class Access Modifier to make it a 'Sealed' class
    /*sealed*/ public class SealedClassExample_Animal       
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    public class SealedClassExample_Dog : SealedClassExample_Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking...");
        }
    }
}
