using System.ComponentModel.Design;
using System.Net.Sockets;

namespace MethodOverloading
{
    using System;

    public class Program
    {
        //Create a Method namedAdd that accepts two int and returns the sum of two int
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        //Overloaded method to add two decimals
        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        //Overloaded method to add two integers and return a string
        public static string Add(int numOne, int numTwo, bool includeDollar)
        {
            var sum = numOne + numTwo;
            if (includeDollar)
            {
                //Determine if "dollar or dollars" should be used
                var dollarWord = sum == 1 ? "dollar" : "dollars";
                return $"{sum} {dollarWord}";
            }

            //Just return the sum as a var:string without "dollar or "dollars"
            return sum.ToString();
        }
        static void Main(string[] args)
        {
            //This method will give the correct answer in integer
            var intA = 40;
            var intB = 50;

            var intAnswer = Program.Add(intA, intB);

            //This method will give the correct answer in decimal
            var decimalA = 22.4m;
            var decimalB = 75.3m;

            var decimalAnswer = Program.Add(decimalA, decimalB);

            var thirdAnswer = Program.Add(0, 0, true);

            Console.WriteLine($"int add: {intAnswer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }
    }
}
        
        
                
                
                
                


