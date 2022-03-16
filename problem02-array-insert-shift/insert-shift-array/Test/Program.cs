using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*");

            //First criteria
            int[] firstArray = { 2, 4, 6, -8 };
            int firstNumber = 5;

            //second criteria
            int[] secondArray = { 42, 8, 15, 23, 42 };
            int secondNumber = 16;

            //Change the arguments of this functions
            int[] returnedArray = InsertShiftArray(secondArray, secondNumber);

            for (int i = 0; i < returnedArray.Length; i++)
            {
                Console.WriteLine(returnedArray[i]);
            }

        }

        static int[] InsertShiftArray(int[] arr, int num)
        {
            //store the passed array
            int[] passedArray = arr;

            //store the passed number
            int addedValue = num;

            //I make an empty array with old length + 1, because we will add a number to it
            int[] resultArray = new int[arr.Length + 1];

            //assign an index where we add our number
            int myIndex = (resultArray.Length / 2);

            //now we loop and add some logice because the passed array is smaller than our resultArray
            for (int i = 0; i < resultArray.Length; i++)
            {
                if (i == myIndex)
                {
                    resultArray[i] = addedValue;
                }
                else if(i > myIndex)
                {
                    resultArray[i] = passedArray[i - 1];
                }
                else if(i < myIndex)
                {
                    resultArray[i] = passedArray[i];
                }
            }
            return resultArray;
        }

        
    }
}
