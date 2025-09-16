using System;

namespace nonoooo
{
    internal class Test
    {
        public void Exercise()
        {
            int[] arr = { 871, 34, 56, 45, 89 };

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
