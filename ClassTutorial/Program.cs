using System;

namespace ClassTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var tqlmath = new TqlMath();
            tqlmath.A = 21;
            tqlmath.B = 30;
            var minus = tqlmath.Minus();
            var sum = tqlmath.Sum();

            Console.WriteLine($"The Sum of {tqlmath.A} and {tqlmath.B} is {sum} ");

            
            Console.WriteLine($"The difference of {tqlmath.A} and {tqlmath.B} is {minus} ");
        }
    }
}
