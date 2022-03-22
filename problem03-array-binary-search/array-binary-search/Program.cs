using System;

namespace array_binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] myArray = { 11, 22, 33, 44, 55, 66, 77 };
            int key = 15;
            Console.WriteLine(BinarySearch(myArray, key)); 
            */
        }

        static int BinarySearch(int[] sortedArr, int key)
        {
            //cache the passed values
            int[] myPassedArray = sortedArr;
            int searchedValue = key;

            //default value if it doesn't exist
            int myIndex = -1;

            //search if the value "key" is in the array
            //if it exists in the array, return its index
            //if not return -1

            for (int i = 0; i < myPassedArray.Length; i++)
            {
                if (myPassedArray[i] == searchedValue)
                {
                    myIndex = i;

                    break;
                }
                else
                {
                    myIndex = -1;
                }
            }

            return myIndex;
        }
    }
}
