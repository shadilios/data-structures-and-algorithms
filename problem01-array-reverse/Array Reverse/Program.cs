using System;

namespace Array_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array I want to reverse
            int[] inputArray = { 1, 2, 3, 4, 5, 6, 7 };
            
            //resulting array equal to the function's return value (which is the passed array reversed)
            int[] someArrayReversed = ReverseArray(inputArray);

            //a test to loop through reversed array and check if it actually loops or not
            for (int i = 0; i < someArrayReversed.Length; i++)
            {
                Console.WriteLine(someArrayReversed[i]);
            }
            
        }

        static int[] ReverseArray(int[] arr)
        {
            //first I want to make an empty array that has the same length as my passed array
            int[] reversedArray = new int[arr.Length];

            //now I loop through array from end to start
            for (int i = arr.Length -1; i >= 0; i--)
            {
                //basically on the first loop I wanna set my left array element to be 0 and right one to be (length-1)
                //now since i = length -1, I set the right side to it, which is my last element in the array
                //and on the left side, I have to make sure that each time I loop, I start from 0
                //until I reach the length -1 value, which is possible only with this formula

                reversedArray[(arr.Length -1) - i] = arr[i];

                //note: if I looped arr from 0 to arr.length -1, then I simply need to change my code into
                //reversedArray[(arr.length -1) -i] = arr[i];
            }
            return reversedArray;
        }
    }
}
