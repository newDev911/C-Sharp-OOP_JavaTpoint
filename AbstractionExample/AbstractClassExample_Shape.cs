using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
// Abstract CLASS:
    Abstraction is the process to hide the internal details and showing functionality only.
    Abstraction can be achieved by two ways:
        1. Abstract Class
        2. Interface

    Abstract METHOD:

    A method which is declared abstract and has no body is called "Abstract Method".
    It can be declared inside a "Abstract Class" only
    ** It's implementation must be provided by derived class
    
     *** An "Abstract Method" is internally a virtual method so it can be overridden by derived class.
     * 
     "Abstract Class" can have abstract and non-abstract methods.
     It cannot be instantiated
    
*/
namespace CSharpOOP_JavaTpoint.AbstractionExample
{
    public abstract class AbstractClassExample_Shape // Abstract class declaration
    {
        public abstract void draw(); // Abstract Method Declaration
    }

    public class Rectangle : AbstractClassExample_Shape
    {
        public override void draw() // draw() method from parent abstract class must be overridden, or it'll throw error
        {
            Console.WriteLine("Drawing Rectangle...");
        }
    }

    public class Circle : AbstractClassExample_Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle....");
        }
    }
}
