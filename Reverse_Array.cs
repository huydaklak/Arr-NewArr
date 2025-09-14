using System;
namespace nonoooo
{
    internal class Reverse_Array
    {
        public void Exercise()
        {
            int[] arr = { 87, 34, 56, 45, 12 };


            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
