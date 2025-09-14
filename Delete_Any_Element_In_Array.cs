using System;

namespace nonoooo
{
    internal class Delete_Any_Element_In_Array
    {
        public void Exercise()
        {
            int[] arr = { 187, 34, 56, 45, 12 };

            int[] newArr = new int[arr.Length - 1];
            int x = 2;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < x)
                {
                    newArr[i] = arr[i];
                }
                else if (i > x)
                {
                    newArr[i - 1] = arr[i];
                }
            }

            arr = newArr;

            foreach (int result in arr)
            {
                Console.WriteLine(result);
            }

        }
    }
}
