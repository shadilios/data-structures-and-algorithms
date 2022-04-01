using System;

namespace array_binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] myArray = { 11, 22, 33, 44, 55, 66, 77 };
            int key = 33;
            Console.WriteLine(BinarySearch(myArray, key)); 
            
        }

        static int BinarySearch(int[] sortedArr, int key)
        {
            //set 2 pointers left and right, and search values between them
            //and change left and right values each time we don't find the element

            //cache the passed values
            int[] myPassedArray = sortedArr;
            int searchedValue = key;

            //Assign left and right value
            int left = 0;
            int right = myPassedArray.Length - 1;

            //default value if it doesn't exist
            int myIndex = -1;

            //search if the value "key" is in the array
            //if it exists in the array, return its index
            //if not return -1

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (key == myPassedArray[middle])
                {
                    myIndex = middle;
                    break;
                }
                else if(key > myPassedArray[middle])
                {
                    left = middle + 1;
                }
                else if (key < myPassedArray[middle])
                {
                    right = middle - 1;
                }

            }
            
            return myIndex;

        }
    }
}
