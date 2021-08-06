using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
// INTERFACE:
        Interface is a blueprint of class. It is like abstract class because all the methods which are decalred 
        inside the 'interface' are abstract methods. 
        
        Like 'abstract' class
        > It cannot have method body 
        > It cannot be instantiated

    It is used to achieve mulitple inheritance which can't be achieved by class.
    It is used to achieve fully abstraction because it cannot have method body.

    It's implementation must be provided by class or struct.
    The class or struct which implements the 'interface', must provide the implementation of all methods declare inside the 'interface'
     
*/      
namespace CSharpOOP_JavaTpoint.AbstractionExample
{
    public interface InterfaceClassExample_Drawable
    {
        void draw();
        
        // ** Interface methods are 'public' and 'abstract' by default. 
        // You cannot explicitly use 'public' and 'abstract' keywords for an interface method
    }

    public class Rectangle2: InterfaceClassExample_Drawable
    {
        // must implement 'draw' method from interface which has been derived
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }
    }

    public class Circle2: InterfaceClassExample_Drawable
    {
        // must implement 'draw' method from interface which has been derived
        public void draw()
        {
            Console.WriteLine("Drawing Circle...");
        }
    }
}
