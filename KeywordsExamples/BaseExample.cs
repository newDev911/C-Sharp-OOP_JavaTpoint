using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.KeywordsExamples
{
    // BASE KEYWORD:
    //      Base keyword is used to access fields, methods and constructors of Base class.
    //      You can use Base keyword within instance method, constructor or instance property accessor only.
    //      * You can't use Base keyword inside Static method
    //      It is very useful when base and dervied class have the same fields
    public class BaseExample
    {
        public string color1 = "Blue";
        public virtual void work(){
            Console.WriteLine("Employee Working...");
        }
    }

    public class BaseExample_B:BaseExample
    {
        public string color1 = "Black";

        public void showColor()
        {
            Console.WriteLine("Color of Parent Class: {0}", base.color1);
            Console.WriteLine("Color of Child Class: {0}", color1);
        }

        public override void work()
        {
            Console.WriteLine("\nParent Class Method:");
            base.work();
            Console.WriteLine("\nChild Class Method:");
            Console.WriteLine("Employee Not Working");
        }
    }
}
