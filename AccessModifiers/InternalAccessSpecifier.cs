using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.AccessModifiers
{

    // The internal keyword is used to specify the internal access specifier for the variables and functions. 
    // This specifier is accessible only within files in the same assembly
    class InternalAccessSpecifier
    {
        internal string name = "John Doe";
        internal void Msg(string msg)
        {
            Console.WriteLine("Hello : " + msg);
        }
    }


    // PROTECTED INTERNAL SPECIFIE:
    //      Variables or functions declared 'protected internal' can be accessed in the assembly which it is declared.
    //      It can also be accessed within a derived class in another assembly.

    class ProtectedInternalSpecifier
    {
        protected internal string name2 = "Josh Blue";

        protected internal void newMsg(string newMsg)
        {
            Console.WriteLine("Msg: " + newMsg);
        }
    }
}
