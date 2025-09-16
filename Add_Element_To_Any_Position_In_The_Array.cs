using System;

namespace nonoooo
{
    internal class Add_Element_To_Any_Position_In_The_Array
    {
        public void Exercise()
        {
            int[] arr = { 871, 34, 56, 45 };

            int[] newArr = new int[arr.Length + 1];

            int posion = 2;
            int number = 999;

            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < posion)
                {
                    newArr[i] = arr[i];
                }
                else if (i == posion)
                {
                    newArr[i] = number;
                }
                else
                {
                    newArr[i] = arr[i - 1];
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
