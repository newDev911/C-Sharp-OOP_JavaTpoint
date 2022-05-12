using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.StringExample
{
    public class StringExamples
    {

        public void stringExample_CharToString(char[] charVal)
        {
            string s2 = new string(charVal);

            Console.WriteLine(charVal);
        }

        // Clone() method is used to clone a string object. It returns another copy of same data
        // Return type of Clone() method is Object - It returns a reference
        public void stringExample_Clone(string ss)
        {
            string s2 = (String)ss.Clone();

            Console.WriteLine("Old String:" + ss);
            Console.WriteLine("Clone String:" + s2);

        }

        // Compare() method is used to comapre first string with second string. 
        // It returns 0, if both strings are equal.
        // It returns 1, if first string is greater than second string.
        // Else it returns -1.

        /*
         Rule:
            s1==s2 returns 0  
            s1>s2 returns 1  
            s1<s2 returns -1

        Signatures:
            public static int Compare(String first, String second)  
            public static int Compare(String, Int32, String, Int32, Int32)  
            public static int Compare(String, Int32, Int32, String, Int32, Boolean)   
            public static int Compare(String, Boolean, Int32, Int32, String, Int32, CultureInfo)   
            public static int Compare(String, CultureInfo, Int32, Int32, String, Int32, CompareOptions)   
            public static int Compare(String, Int32, Int32, String, Int32, StringComparison)  
            public static int Compare(String, String, Boolean)   
            public static int Compare(String, String, Boolean, CultureInfo)   
            public static int Compare(String, String, CultureInfo, CompareOptions)  
            public static int Compare(String, String, StringComparison)  

        Parameters:
            first: first argument represents string which is to be compared with second string.
            second: second argument represents string which is to be compared with first string.

         Return:
            It returns an integer value.
         */

        public void stringExample_Compare(string ss)
        {
            string s2 = (String)ss.Clone();

            Console.WriteLine("Old String:" + ss);
            Console.WriteLine("Clone String:" + s2);

        }
    }
}
