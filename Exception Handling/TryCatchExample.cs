using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.Exception_Handling
{
    public class TryCatchExample
    {
        
        public double division_WithoutTryCatch(int val_a, int val_b)
        {
            double ans = Convert.ToDouble(val_a / val_b); // The Code will crash here
            Console.WriteLine("Rest Of the Code...");
            return ans;
        }

        public double division_WithTryCatch(int val_a, int val_b)
        {
            double ans = 0;
            try
            {
                ans = Convert.ToDouble(val_a / val_b);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("\n\nRest Of the Code...");
            return ans;
        }

        public double division_WithTryCatch_Finally(int val_a, int val_b)
        {
            double ans = 0;
            try
            {
                ans = Convert.ToDouble(val_a / val_b);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Code Executed!");
            }

            Console.WriteLine("\n\nRest of the Code...");
            return ans;
        }
    }


}

