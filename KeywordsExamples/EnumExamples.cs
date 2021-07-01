using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_JavaTpoint.KeywordsExamples
{
    // Enum is also known as enumeration. 
    // It is used to store a set of named 'constants' such as season, days, months, size etc. 
    // The Enum constants also known as Enumerators. 
    // Enum can be declared within or outiside of Class and Structs

    // ENIUM POINTS:
    //      > Enum has fixed set of constants
    //      > Enum improves type safety
    //      > Enum can be traversed
    class EnumExamples
    {
        public enum Season
        {
            WINTER,
            SPRING,
            SUMMER,
            FALL
        }

        public enum Season2
        {
            WINTER = 12,
            SPRING
        }

        public enum enumDays
        {
            Sun,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat
        }

        public void enumIndexExample(int x, int y)
        {
            Console.WriteLine("Index of Winter: {0}", x);
            Console.WriteLine("Index of Summer: {0}", y);
        }
        public void enumChangeStartIndex(int x, int y){
            Console.WriteLine("Index of Winter: {0}", x);
            Console.WriteLine("Index of Spring: {0}", y);
        }

        public void printEnumValues()
        {
            foreach(String s in Enum.GetNames(typeof(enumDays))){
                Console.WriteLine("Day: {0}", s);
            }
        }
    }
}
