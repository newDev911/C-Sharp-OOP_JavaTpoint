using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.Encapuslation
{
    // ENCAPSULATION:
    /*
     * Encapsulation is the concept of wrapping data into single unit. 
     * It collects data members and member functions into a single unit called 'Class'
     * The purpose of Encapsulation is to prevent alteration of data from outside
     * This data can only be accessed by 'getter' functions of the class
     * A fully 'Encapsulated' class has 'getters' & 'setters', that are used to read and write data.
     */
    class EncapsulationExample_Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}

