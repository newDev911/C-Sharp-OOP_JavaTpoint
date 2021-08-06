using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
// NAMESPACES:
        Namespaces are used to organize too many classes so that it can be easy to handle the application

    We use 'System.Console' where 'System' is the namespace and 'Console' is the class
    To access the Class of a Namespace, we need to use 'namespace.className'
    ** We can use 'using' keyword on top of document so that we don't have to use complete name all the time
    * 
    * Global namespace is the root namespace.
    * The global::System will always refer to the namespace "System" of .Net framework

*/
namespace CSharpOOP_JavaTpoint.NamespacesExample.NamespaceExp
{
    public class NamespaceExample_Hello
    {
        // This class exists in 'CSharpOOP_JavaTpoint.NamespacesExample.NamespaceExp' namespace
        // import namespace in Program.cs by using 'using' keyword
        public void dis_Msg()
        {
            Console.WriteLine("Hello Namespace");
        }

    }
}

// FULLY QUALIFIED NAMESPACE NAME (Cutom NamespaceName)
namespace Namespace_a
{
    public class NamespaceExample_First
    {
        // This class object can be created by 'Namespace_a.NamespaceExample_First' 
        // So we don't need to use 'import' in our 'Program.cs'
        public void dis_Msg()
        {
            Console.WriteLine("Hello Namespace");
        }
    }
}
