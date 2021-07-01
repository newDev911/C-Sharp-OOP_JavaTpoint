using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.Polymorphism
{
    // METHOD OVERLOADING:
    // If we create two or more methods having same name but different in number or type of parameter, it is known as Method Overloading
    //  We can overload:
    //      > Methods
    //      > Constructor
    //      > Indexed Properties

    // The adavantage of method overloading is that it increases the readibility of program because you don't need to use differnt names for same action
    class MethodOverloadingExample
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static double add(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}
