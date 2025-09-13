using System;

namespace nonoooo
{
    internal class test
    {
        public void Fvck()
        {
            Console.WriteLine("Nhap so luong phan tu mang : ");
            int caseChoice = int.Parse(Console.ReadLine());

            int[] arr = new int[caseChoice];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Nhap phan tu thu {0}", (i + 1));
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }

            foreach (int outChoice in arr)
            {
                Console.WriteLine(outChoice);
            }
        }
    }
}
