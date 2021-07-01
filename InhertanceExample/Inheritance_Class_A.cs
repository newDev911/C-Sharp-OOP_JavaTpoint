using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.InhertanceExample
{
    // Inheritance is a process in which one object acquires all the properties and  behaviors of its parent object automatically. 
    // In such way you can use, extend or modify the attributes and behaviors which is defined in our class.
    // The class which inherits the members of another class is called "Derived Class" and the class whose members are inherited is called "Base CLass"

    // SINGLE LEVEL INHERITANCE
    class Inheritance_Class_A
    {
        public string weight = "30kg";

        public void eating()
        {
            Console.WriteLine("Eating....");
        }
    }

    class Inheritance_Class_B: Inheritance_Class_A
    {
        public void bark()
        {
            Console.WriteLine("Barking....");
        }
    }


}
