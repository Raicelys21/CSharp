using System;
namespace Ejercicio1
{
    class Program
    {
        static int N = 4;
        static int[] Buf = new int[N];
        static bool[] Used = new bool[N];

        static void Main()
        {
            for (int i = 0; i < N; i++) 
                Used[i] = false;
            Rec(0);
        }

        static void Rec(int ind)
        {
            for (int i = 0; i < N; i++)
            {
                if (!Used[i] && i != ind)
                {
                    Used[i] = true;
                    Buf[ind] = i;
                    if (ind + 1 < N) Rec(ind + 1);
                    else Console.WriteLine(string.Join(",", Buf));
                    Used[i] = false;
                }
            }
        }
    }
}








