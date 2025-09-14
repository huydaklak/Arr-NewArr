using System;

namespace nonoooo
{
    internal class Add_Last_Element_To_Array
    {
        public void Exercise()
        {

            int[] arr = { 87, 34, 56, 45 };

            int[] newArr = new int[arr.Length + 1];
            int a = 8;

            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < arr.Length)
                {
                    newArr[i] = arr[i];
                }
                else
                {
                    newArr[i] = a;
                }
            }

            foreach (int i in newArr)
            {
                Console.WriteLine(i);
            }

        }

    }
}
