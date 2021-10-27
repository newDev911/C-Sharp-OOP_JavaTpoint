using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.AccessModifiers
{
    // It makes data accessible publicly.
    // It doesn't restrict data to the declared block
    public class PublicAccessSpecifier
    {
        public string name = "Don Jon";
        public void MsgFun(string msg) {
            Console.WriteLine("Hello " + msg);
        }
    }
}
