using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.Exception_Handling
{
    /// <summary>
    /// This class can be used to handle exception of subclasses.
    /// </summary>

    public class SystemExceptionExample
    {

        public void systemExceptionExampleMethod()
        {
            try
            {
                int[] arr = new int[5]; // Length of array is 5
                arr[10] = 25; // 10th index doesn't exists
            }
            catch(SystemException e)
            {
                Console.WriteLine(e);
            }
        }
        // The following program will throws an "IndexOutOfRangeException"
        // that is subclass of "SystemException" class.
    }
}
