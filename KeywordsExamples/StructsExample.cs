using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.KeywordsExamples
{
    // Classess and Structs are blueprints that are used to create instance of class.
    // Structs are used for lightweight objects such as Color, Rectangle, Point etc.

    // Unlike CLASS, STRUCTS are value type rather than reference type.
    // It is useful if you have data that is not intended to be modified after creation of STRUCT.

    // * Structs doesn't support inheritance. But it can implement interfaces.
    public struct StructsExample
    {
        // Width and Height of rectangle
        public int width, height;
    }

    public struct Rectangle_Struct{
        public int width, height;

        public Rectangle_Struct(int w, int h){
            width = w;
            height = h;
        }

        public void areaOfRectangle(){
            Console.WriteLine("Area of Rectangle: {0}", (width * height));
        }
    }
}
