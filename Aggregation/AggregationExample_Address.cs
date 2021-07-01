using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.Aggregation
{
    // AGGREGATION:
        //  Aggregation is a process in which one class defines another class as an entity reference.
        // It is another way to reuse the class
        // It is a form of association that represents HAS-A relationship
    public class AggregationExample_Address
    {
        public string addressLine, city, state;

        public AggregationExample_Address(string addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }

    public class AggregationExample_Employee
    {
        public int id;
        public string name;
        public AggregationExample_Address address;  // This class HAS-A AggregationExample_Address class;

        public AggregationExample_Employee(int id, string name, AggregationExample_Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public void display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address.addressLine);
            Console.WriteLine("City: " + address.city);
            Console.WriteLine("State: " + address.state);
        }
    }

}
