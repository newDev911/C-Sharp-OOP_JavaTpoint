using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// These keywords used to handle integral type exceptions.
/// They are used to checked and unchecked context respectively.
/// 
/// CHECKED CONTEXT:
///     In checked context, arithmetic overflow raises an exception
///     
/// UNCHECKED CONTEXT:
///    In an unchecked context, arithmetic overflow is ignored and result is truncated.
/// </summary>
namespace CSharpOOP_JavaTpoint.Exception_Handling
{
    public class Checked_Unchecked
    {
        public void checkedExample()
        {
            int val = int.MaxValue;
            Console.WriteLine(val + 2);
            // The above code will produce wrong result, but it doesn't throw any overflow exception. 
        }

        public void checkedExample_checkedKeyword()
        {
            checked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
            // The above code will throw an "Unhandled Exception"
        }

        public void unCheckedExample_uncheckedKeyword()
        {
            unchecked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
            // The "unchecked" ignores the integral type arithmetic exceptions
            // It doesn't check explicity and produce result that may be
            // truncated or wrong.
        }
    }


}
