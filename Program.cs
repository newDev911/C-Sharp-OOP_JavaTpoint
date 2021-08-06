using CSharpOOP_JavaTpoint.Classes_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP_JavaTpoint.Constructor_Destructor;
using CSharpOOP_JavaTpoint.KeyworExamples;
using CSharpOOP_JavaTpoint.staticExample;
using CSharpOOP_JavaTpoint.KeywordsExamples;
using CSharpOOP_JavaTpoint.PropertiesExample;
using CSharpOOP_JavaTpoint.InhertanceExample;
using CSharpOOP_JavaTpoint.Aggregation;
using CSharpOOP_JavaTpoint.Polymorphism;
using CSharpOOP_JavaTpoint.AbstractionExample;
using CSharpOOP_JavaTpoint.NamespacesExample.NamespaceExp;

namespace CSharpOOP_JavaTpoint
{
    class Program
    {
        public static void Main(string[] args)
        {
            Classes_Objects_Example obj1 = new Classes_Objects_Example();
            DisplayDataThroughMethod obj2a = new DisplayDataThroughMethod();
            DisplayDataThroughMethod obj2b = new DisplayDataThroughMethod();
            ShowEmployeeData obj3a = new ShowEmployeeData();
            ShowEmployeeData obj3b = new ShowEmployeeData();

            /*            
            obj1.id = 22;
            obj1.name = "Jake";
            Console.WriteLine(obj1.id);
            Console.WriteLine(obj1.name);
            */

            /*            
            obj2a.insert(101, "Hyse");
            obj2b.insert(102, "Maze");
            obj2a.display();
            obj2b.display();
            */
            /*
            obj3a.insert(11, "Java", 2250);
            obj3b.insert(22, "Mate", 3650);

            obj3a.display();
            obj3b.display();
            */
            /*
            // Default Constructor Example
            ConstructorExample obj4 = new ConstructorExample();

            ConstructorExample2 obj5 = new ConstructorExample2(102, "John", 22000);
            ConstructorExample2 obj5_2 = new ConstructorExample2(103, "Jake", 10000);

            obj5.display();
            obj5_2.display();
            */

            /*
            DestructorExample obj6 = new DestructorExample();
            DestructorExample obj6_b = new DestructorExample();
            */

            /*
             // this Example:
            thisKeywordExample obj7 = new thisKeywordExample(101, "Jade", 220000);
            thisKeywordExample obj7b = new thisKeywordExample(103, "Kate", 330000);

            obj7.display();
            obj7b.display();
            */

            /*
            staticFieldExample obj8 = new staticFieldExample(545, "John");
            staticFieldExample obj8b = new staticFieldExample(646, "Jane");
            obj8.display();
            Console.WriteLine();
            obj8b.display();
            Console.WriteLine();
            Console.WriteLine("Total Objects: {0}", staticFieldExample.counter); // Calling 'static' field
             */
            /*
            // STATIC CLASS EXAMPLE:
            Console.WriteLine("Value of PI: {0}", StaticClassExample.PI);
            Console.WriteLine();
            Console.WriteLine("Cube of 9: {0}", StaticClassExample.cube(9));
            */

            /*
            // STATIC CONSTRUCTOR EXAMPLE:
            StaticConstructorExample obj9 = new StaticConstructorExample(112, "Kim");
            StaticConstructorExample obj9b = new StaticConstructorExample(115, "Jim");

            obj9.display();
            obj9b.display();
            */
            /*
            StructsExample obj10 = new StructsExample();
            obj10.height = 5;
            obj10.width = 4;
            Console.WriteLine("Area of Rectangle: {0}", (obj10.width * obj10.height));
            Console.WriteLine();

            Rectangle_Struct obj10b = new Rectangle_Struct(5, 6);
            obj10b.areaOfRectangle();
            */

            /*
            // ENUM EXAMPLE:
            int x;
            int y;
            EnumExamples obj11 = new EnumExamples();
            x = (int)EnumExamples.Season.WINTER;
            y = (int)EnumExamples.Season.SUMMER;
            obj11.enumIndexExample(x, y);

            Console.WriteLine();
            int i;
            int j;
            i = (int)EnumExamples.Season2.WINTER;
            j = (int)EnumExamples.Season2.SPRING;
            obj11.enumChangeStartIndex(i, j);
            
            Console.WriteLine();
            obj11.printEnumValues();
            */
            /*
            PropertiesExampleClass_A obj12 = new PropertiesExampleClass_A();
            obj12.Name = "Mike Dane";
            Console.WriteLine("Employee Name: {0}", obj12.Name);
            */
            /*
            PropertiesExampleClass_B obj13 = new PropertiesExampleClass_B();
            obj13.Name = "Sarah Khan";
            Console.WriteLine(obj13.Name); // ''Employee Name' string is from 'set' value'
            */
            /*
            PropertiesExampleClass_C obj14 = new PropertiesExampleClass_C();
            PropertiesExampleClass_C obj14b = new PropertiesExampleClass_C();
            PropertiesExampleClass_C obj14c = new PropertiesExampleClass_C();

            Console.WriteLine("Number of Objects: {0}", PropertiesExampleClass_C.Counter);
            */

            /*
            // SINGLE LEVEL INHERITANCE:
            Inheritance_Class_B obj15 = new Inheritance_Class_B();
            Console.WriteLine("Animal Weight: {0}", obj15.weight);
            Console.WriteLine("\nEat Now!");
            obj15.eating();
            Console.WriteLine("\nBark Now!");
            obj15.bark();
            /
             */

            /*
            // MULTI-LEVEL INHERITANCE:
            InheritanceExampleB_BabyDog obj16 = new InheritanceExampleB_BabyDog();
            obj16.eat();
            obj16.bark();
            obj16.weep();
             */
            /*
            AggregationExample_Address obj17 = new AggregationExample_Address("Bk-6, Street 4, Clifton", "Karachi", "Sindh");
            AggregationExample_Employee obj18 = new AggregationExample_Employee(22, "Jamil", obj17);

            obj18.display();
            */

            /*
            // METHOD OVERLOADING
            Console.WriteLine("Add Two Integers: {0}", MethodOverloadingExample.add(2, 4));
            Console.WriteLine("Add Three Integers: {0}", MethodOverloadingExample.add(4, 6, 8));
            Console.WriteLine("Add Three Doubles: {0}", MethodOverloadingExample.add(22.4, 33.2, 4453.7));
            */
            /*
            // METHOD OVERRIDING:
            MethodOverridingExample_Goat obj19 = new MethodOverridingExample_Goat();
            obj19.eat();
            */

            /*
            // BASE KEYWORD:
            BaseExample_B obj20 = new BaseExample_B();
            obj20.showColor();
            obj20.work();
            */

            /*
            // CONSTRUCTOR WITH INHERITANCE:
            ConstructorWithInheritance_Cat obj21 = new ConstructorWithInheritance_Cat();
            */

            // Polymorhism Example
            /*    
            RuntimePolymorphism_Animal obj22 = new RuntimePolymorphism_Dog();            
            obj22.eat();
            */
            /*
            RuntimePolymorphism_Shape obj23 = new RuntimePolymorphism_Shape();
            obj23.draw();
            RuntimePolymorphism_Shape obj24 = new RuntimePolymorphism_Rectangle();
            obj24.draw();
            RuntimePolymorphism_Shape obj25 = new RuntimePolymorphism_Circle();
            obj25.draw();
            */

            /*
            RuntimePolymorphism_Car obj26 = new RuntimePolymorphism_Truck();
            Console.WriteLine(obj26.color);
            */
            /*
            // SEALED CLASS EXAMPLE
            SealedClassExample_Dog obj27 = new SealedClassExample_Dog();
            obj27.eat(); // Error: "Sealed class cannot be inherit by another class"
            obj27.bark(); // Error: "Sealed class cannot be inherit by another class"
            */

            /*
             // ABSTRACTION EXAMPLE:
            AbstractClassExample_Shape obj28 = new Rectangle();
            obj28.draw(); // Calling overridden method

            AbstractClassExample_Shape obj29 = new Circle();
            obj29.draw(); // Calling overridden method
            

            // INTERFACE EXAMPLE
            InterfaceClassExample_Drawable obj30 = new Rectangle2();
            obj30.draw();

            InterfaceClassExample_Drawable obj31 = new Circle2();
            obj31.draw();

            */

            // NAMESPACE EXAMPLE:
            // Example 1:
            NamespaceExample_Hello obj32 = new NamespaceExample_Hello();
            obj32.dis_Msg();
            
            // Example 2:
            Namespace_a.NamespaceExample_First obj33 = new Namespace_a.NamespaceExample_First();

            Console.ReadKey();   
        }

    }
}
