using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.AccessModifiers
{
    // It is accessible within the class andd has limited scope.
    // It is also accessible within sub class or child class, in case of inheritnce
    class ProtectedAccessSpecifier
    {
        protected string name = "Mike Dane";

        protected void MsgFun(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }

    class ProtectedAccess2 : ProtectedAccessSpecifier
    {
        public void printName()
        {
            Console.WriteLine("Hello " + name);
        }
        
        public void printMsg()
        {
            string msg = "It's Over";
            MsgFun(msg);
        }
    }
}
