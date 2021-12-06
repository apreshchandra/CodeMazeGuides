using System;

namespace ActionAndFuncDelegates
{
    /// <summary>
    /// This class illustrates the usage of Action and Func delegates.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// The Main method
        /// </summary>
        public static void Main()
        {
            //Action delegate
            Action<string> action = SaySomething;
            action += w => Console.WriteLine("I have said {0}", w);
            action("a lot!");


            //Func delegate
            Func<int, int, int, int> func = CalculateSomething;
            func += (int a, int b, int c) =>
            {
                return a + b + c;
            };
            Console.WriteLine(func(10, 20, 30));
        }

        /// <summary>
        /// Works with Action delegate because, it has not return type 
        /// </summary>
        /// <param name="words">The text to process and display</param>
        public static void SaySomething(string words)
        {
            Console.WriteLine("I said {0}.", words);
        }

        /// <summary>
        /// Works with Func delegate because it has a return type (of int)
        /// </summary>
        /// <param name="numberOne">The first number</param>
        /// <param name="numberTwo">The second number</param>
        /// <param name="numberThree">The third number</param>
        /// <returns>The sum of all input numbers</returns>
        public static int CalculateSomething(int numberOne, int numberTwo, int numberThree)
        {
            return numberOne + numberTwo + numberThree;
        }
    }
}
