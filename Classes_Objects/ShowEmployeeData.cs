using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.Classes_Objects
{
    public class ShowEmployeeData
    {
        public int id;
        public String name;
        public float salary;

        public void insert(int i, String n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }

        public void display()
        {
            Console.WriteLine("Employee Id: {0}\nEmployee Name: {1}\nEmployee Salary: {2}", id, name, salary);
        }
    }
}
