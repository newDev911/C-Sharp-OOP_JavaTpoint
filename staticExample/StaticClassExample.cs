using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.staticExample
{
    // 'Static Class' is like a normal class but it cannot be instatiated.
    // It can only have static members.
    // STATIC CLASS POINTS:
    //      > Static class contains only static members
    //      > Static class cannot be instantiated
    //      > Static class is sealed
    //      > Static class cannot contain instance constructors
    public static class StaticClassExample
    {
        public static float PI = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }

    }
}
