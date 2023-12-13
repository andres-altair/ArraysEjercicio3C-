using System.Drawing;

namespace ArraysEjercicio3C
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[,] ar = new int[10,10];
            for (int i = 100; i >1; i--)
            {
                ar[i,-i] = i;
                Console.WriteLine(ar[i,i]);
            }
           for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(ar[i, j]);
                }
            }
        }

    }
}