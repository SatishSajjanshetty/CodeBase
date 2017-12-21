using System;

namespace Polymorphism_CompileTime
{
    internal class Program
    {
        private static void Main()
        {
            var overload = new Overload();

            //Based on parameter type and number of parameters respective overload method will be called
            overload.DisplayOverload(100);
            overload.DisplayOverload(100, 200);
            overload.DisplayOverload(100, "Satish");
      
            Console.ReadKey();
        }

        public class Overload
        {
            //Return type is not a part of method signature
           public int DisplayOverload(int a)
            {
                Console.WriteLine(a);
                return a;
            }

            //Number of parameters are part of method signature
            public int DisplayOverload(int a, int b)
            {
                Console.WriteLine(a + " " + b);
                return a;
            }

            //Diffrent data type in parameters are part of method signature
            public void DisplayOverload(int a, string b)
            {
                Console.WriteLine(a +" "+ b);
            }
        }
    }




}
