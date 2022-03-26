using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Fibonacci(45));
            //Console.WriteLine(Convert.ToInt32(FibonacciEquation(45)));
            //Console.WriteLine(NthFibonacciNumber(14));
            
        }



        static int Fibonacci(int x)
        {
            int passedNum = x;

            int[] arr = new int[passedNum + 1];

            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 1;

            //create array
            for (int i = 3; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
                
            }

            //return final element, don't use if statement
            return arr[arr.Length -1];
        }

        public static int FibonacciRecursive(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return (FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2));
            }
        }




        static double FibonacciEquation(double x)
        {
            double n = x;

            double Phi = ((1 + Math.Sqrt(5)) / 2);
            double phi = -1 / Phi;

            double PhiSqr = Math.Pow(Phi, n);
            double phiSqr = Math.Pow(phi, n);

            double result = ((PhiSqr - phiSqr) / Math.Sqrt(5));


            return result;
        }

    }


}
