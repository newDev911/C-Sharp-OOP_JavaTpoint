using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.Constructor_Destructor
{
    // Destructor works opposite to Constructor. 
    // It destructs the objects of class. 
    // It can defined only once in a class
    // Like Constructor it is invoked automatically
    class DestructorExample
    {

        public DestructorExample()
        {
            Console.WriteLine("Constructor Invoked!");
            Console.WriteLine();
        }
        
        ~DestructorExample(){
            Console.WriteLine("Destructor Example");
        }
    }
}
