using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.KeyworExamples
{
    // 'this' keyword refers to the current instance of class. There can be 3 main usage of 'this' keyword
    //      > It can be used to refer current class instance variale. It is used if field names (object variables) and parameter names are same
    //      > It can be used to pass current object as parameter to another method
    //      > It can be used to declare indexers


    class thisKeywordExample
    {
        public int id;
        public String name;
        public float salary;

        public thisKeywordExample(int id, String name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void display()
        {
            Console.WriteLine("User Id: {0}", id);
            Console.WriteLine("User Name: {0}", name);
            Console.WriteLine("Salary: {0}", salary);
        }
    }
}
