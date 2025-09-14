using System;

namespace nonoooo
{
    internal class Delete_Last_Element_Of_Array
    {
        public void Exercise1()
        {
            int[] arr = { 87, 34, 56, 45, 12 };

            int[] newArr = new int[arr.Length - 1];


            for (int i = 0; i < arr.Length; i++)
            {
                if (i < newArr.Length)
                {
                    newArr[i] = arr[i];
                }
            }

            foreach (int i in newArr)
            {
                Console.WriteLine(i);
            }
            // 87 34 56 45
        }
    }
}
