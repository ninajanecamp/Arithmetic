using System;

namespace Arithmetic
{

    public class Math
    {

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multi(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Div(int num1, int num2)
        {
            return num1 / num2;
        }
        class program
        {

            static void Main(string[] args)
            {
                Math math = new Math();

                int num1, num2;

                //addition
                Console.WriteLine("Enter num1:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter num2:");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("The total of two numbers  = " + math.Add(num1,num2));

                //subtraction
                Console.WriteLine("Enter num1:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter num2:");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("The total of two numbers = " + math.Sub(num1, num2));

                //multiplication
                Console.WriteLine("Enter num1:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter num2:");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("The total of two numbers = " + math.Multi(num1, num2));

                //division
                Console.WriteLine("Enter num1:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter num2:");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("The total of two numbers = " + math.Div(num1, num2));
            }

        }
    }


}