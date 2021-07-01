using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.Classes_Objects
{
    public class DisplayDataThroughMethod
    {
        public int id;
        public String name;

        public void insert(int i, String n)
        {
            id = i;
            name = n;
        }

        public void display()
        {
            Console.WriteLine("ID: {0} -- Name: {1}", id, name);
        }
    }
}
