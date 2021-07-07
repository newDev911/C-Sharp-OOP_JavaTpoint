using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.Polymorphism
{
    // The term "Polymorphims" is the combination of "poly" + "morphs" which means many forms. 
    // There are two types of Polymorphism:
    //  > Compile Time Polymomrphism
    //   > Runtime Polymorphism

    /*
        Compile Time Polymorphism is achieved by method overloading and operator overloading in C#.
     * It is also known as static binding or early binding.
     * 
     * Runtime Polymorhpism is achieved by methoder overriding which is also known as dynamic binding or late binding
     */
    
    public class RuntimePolymorphism_Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    public class RuntimePolymorphism_Dog: RuntimePolymorphism_Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating Buiscits!");
        }
    }

    public class RuntimePolymorphism_Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing!");
        }
    }

    public class RuntimePolymorphism_Rectangle : RuntimePolymorphism_Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }
    }

    public class RuntimePolymorphism_Circle : RuntimePolymorphism_Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Cirlce...");
        }
    }

    // Runtime Polymorphism can't be acheived by data members in C#

    public class RuntimePolymorphism_Car
    {
        public string color = "White";
    }
    public class RuntimePolymorphism_Truck: RuntimePolymorphism_Car
    {
        public string color = "Black";
    }

}
