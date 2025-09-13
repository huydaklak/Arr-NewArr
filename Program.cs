using System;

namespace nonoooo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 99, 5, 12, 19, 41 };
            //int[] newArr = new int[arr.Length - 1];

            //int a = 12;
            //int x = arr.Length;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == a)
            //    {
            //        x = i;
            //        Console.WriteLine("vi tri cua {0} tai {1}", a, x);
            //        break;
            //    }
            //}

            //int[] arr = { 99, 5, 12, 19, 41 };

            //int a = 12;
            //int x = arr.Length;

            //// B1: tìm vị trí a
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == a)
            //    {
            //        x = i;
            //        Console.WriteLine("Vị trí của {0} tại {1}", a, x);
            //        break;
            //    }
            //}

            //// B2: nếu tìm thấy thì xóa tại vị trí x
            //if (x != arr.Length)
            //{
            //    int[] newArr = new int[arr.Length - 1];

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (i < x)
            //        {
            //            newArr[i] = arr[i];
            //        }
            //        else if (i > x)
            //        {
            //            newArr[i - 1] = arr[i];
            //        }
            //    }

            //    arr = newArr;
            //}

            //// B3: in mảng sau khi xóa
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //int[] arr = new int[] { 1, 2, 3, 4, 5 };

            //int[] newArr = new int[arr.Length + 1];
            //int x = 16;

            //for (int i = 0; i < newArr.Length; i++)
            //{
            //    if (i < arr.Length)
            //    {
            //        newArr[i] = arr[i];
            //    }
            //    else
            //    {
            //        newArr[i] = x;
            //    }
            //}

            //arr = newArr;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //2
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };

            //int[] newArr = new int[arr.Length - 1];

            //int x = 2;

            //for (int i = 0; i < newArr.Length; i++)
            //{
            //    if (arr[i] == x)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        newArr[i - 1] = i;
            //    }
            //}

            //arr = newArr;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //1 int[] arr = { 87, 34, 56, 45, 12 };

            // int[] newArr = new int[arr.Length - 1];

            // for (int i = 0; i < arr.Length; i++)
            // {
            //     if (i < newArr.Length)
            //     {
            //         newArr[i] = arr[i];
            //     }
            //     else if (i > newArr.Length)
            //     {
            //         newArr[arr.Length - 1] = arr[i];
            //     }
            // }

            // foreach (int result in newArr)
            // {
            //     Console.WriteLine(result);
            // }

            int[] arr = { 87, 34, 56, 45 };

            int[] newArr = new int[arr.Length + 1];
            int x = 11;


            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < arr.Length)
                {
                    newArr[i] = arr[i];
                }

                else
                {
                    newArr[i] = x;
                }
            }

            foreach (int result in newArr)
            {
                Console.WriteLine(result);
            }



        }
    }
}

