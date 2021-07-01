using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.staticExample
{

    // 'static' is a keyword or modifier that belongs to the type not instance(object).
    // So, instance (object) is not required to access the static members.

    // STATIC FIELD:
    //  Unlike instance field which gets memory each time whenever you create object, there is only one copy of static field created in memory.
    // It is shared to all the objects
    // It is used to refer the common property of all objects such as rateOfInterest in case of Account, company name in case of Employee etc.
    class staticFieldExample
    {
        public int accNo;
        public String name;
        public static float rateOfInterest = 8.8f;
        public static int counter;

        public staticFieldExample(int accNo, string name)
        {
            this.accNo = accNo;
            this.name = name;
            counter++;
        }
        public void display()
        {
            Console.WriteLine("Account No: {0}", accNo);
            Console.WriteLine("Employee No: {0}", name);
            Console.WriteLine("Rate of Interest: {0}", rateOfInterest);
        }
    }
}
