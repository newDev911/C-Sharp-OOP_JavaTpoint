using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.Constructor_Destructor
{
    // Constructor is a special method which is invoked automatically at the time of object creation. 
    // It is used to initialize the data members of new object generally.
    // There are two types of constructors:
        // 1: Default Constructor
    //  2: Parameterized Constructor
    public class ConstructorExample
    {
        public  ConstructorExample() // Same name as 'Class Name'
        {
            Console.WriteLine("Default Constructor Invoked!");
        }
    }

    public class ConstructorExample2
    {
        public int id;
        public string name;
        public float salary;
        public ConstructorExample2(int i, string n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }

        public void display()
        {
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Salary: {0}", salary);
            Console.WriteLine();
        }
    }
}
