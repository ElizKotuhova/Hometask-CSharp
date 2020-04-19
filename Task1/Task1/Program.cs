using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            int Result = 0;

            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;
            a[4] = 5;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Result += a[i];
                }
            }
            Console.WriteLine(Result);
            
        }
    }
}
