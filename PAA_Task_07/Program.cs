using System;

namespace PAA_Task_07
{
    class Program
    {
        private static void Shuffle(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                var rndInd = rand.Next(0, arr.Length);
                var rndInd2 = rand.Next(0, arr.Length);
                var temp = arr[rndInd];
                arr[rndInd] = arr[rndInd2];
                arr[rndInd2] = temp;
            }
        }

        private static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите количество случайных чисел: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[num];
            Console.Write("Массив из случайных чисел: ");
            for (int i = 0; i < num; i++)
            {
                a[i] = rand.Next(100);
                Console.Write(a[i] + " ");
            }
            Console.Write("\nПеремешанный массив: ");
            Shuffle(a);
            Console.WriteLine(string.Join(" ", a));
        }
    }
}
