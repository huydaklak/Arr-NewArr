using System;

namespace nonoooo
{
    internal class Max_Arr
    {
        public void Exercise()
        {
            int[] arr = { 871, 34, 999, 56, 45 };

            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine(max);
        }
    }
}
