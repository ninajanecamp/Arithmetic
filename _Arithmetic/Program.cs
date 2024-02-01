using System;

namespace Arithmetic
{
    public class Math {

        public int Add(num1, num2)
        {
            return num1 + num2;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Math math = new Math();

                int num1, num2;

                Console.WriteLine("Enter num1:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter num2:");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("total = " + math.Add(num1,num2));
            }
        }
    }
    
}