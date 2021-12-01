using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
        //---------------------------------------------LIST OF BOXED DATA----------------------------------------
            //C1 - Instantiate Empty List of Type Object
            List<object> BoxedData = new List<object>();

            BoxedData.Add(7);
            BoxedData.Add(28);
            BoxedData.Add (-1);
            BoxedData.Add("true");
            BoxedData.Add ("chair");


            
            //C3 - Loop through list and print out each item in list
            foreach (var entry in BoxedData) {
                if (entry is int) {
                    Console.WriteLine(entry);
                }
                if (entry is string) {
                    Console.WriteLine(entry);
                }
            }
        }
    }
}
