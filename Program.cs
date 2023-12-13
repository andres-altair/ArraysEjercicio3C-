using System.Drawing;

namespace ArraysEjercicio3C
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[,] ar = new int[10,10];
            for (int i = 100; i < ar.Length; i--)
            {
                ar[i,-i] = i;
                Console.WriteLine(ar[i].ToString());
            }
           for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar[i].Length; j++)
                {
                    Console.WriteLine(i,j);
                }
            }
        }

    }
}