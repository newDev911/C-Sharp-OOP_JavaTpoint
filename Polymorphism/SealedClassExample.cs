using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.Polymorphism
{
    /*
     SEALED CLASS:
        C# sealed keyword applies restrictions on the class and method. 
        > Sealed class cannot be derived
        > Sealed method cannot be overridden
     */
    public class SealedClassExample
    {

    }

    // Sealed Class Example
    sealed public class SealedClass_Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating");
        }
    }

    public class SealedClassExample_Dog // :Animal //- Inheritance will throw an error
    {
        public void bark()
        {
            Console.WriteLine("Barking");
        }
    }


    // Sealed Method Example
    public class SealedMethodExample_Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating");
        }
        public virtual void run()
        {
            Console.WriteLine("Running");
        }
    }


    public class SealedMethodExample_Dog : SealedMethodExample_Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating Sugar");
        }
        public sealed override void run()
        {
            Console.WriteLine("Running Very fast");
        }
    }

    public class SealedMethodExample_Puppy : SealedMethodExample_Dog
    {
        public override void eat()
        {
            Console.WriteLine("Puppy Eating");
        }
        // ** run() method is sealed in Dog class so it won't override
        //public override void run()
        //{
        //    Console.WriteLine("Puppy Running");
        //}


        // ** Local variables can't be sealed
        // sealed int x = 100;


    }

}
