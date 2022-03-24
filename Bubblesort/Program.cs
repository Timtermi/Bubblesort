using System;
using System.Threading;
namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] Zahl = { 4,15,10,45};
            int temp;
            for (int j = 0; j <= Zahl.Length - 2; j++)
            {
                for (int i = 0; i <= Zahl.Length - 2; i++)
                {
                    if (Zahl[i] > Zahl[i + 1])
                    {
                        temp = Zahl[i + 1];
                        Zahl[i + 1] = Zahl[i];
                        Zahl[i] = temp;
                        
                    }
                    showArray(Zahl);
                }
            } 
          
            Console.WriteLine("Sortiert:");
            foreach (int p in Zahl)
                Console.Write(p + " ");
            
            Console.Read();
        }
        public static void showArray(int[] data, bool balkenMode = false)
        {
            Thread.Sleep(100);
            Console.Clear();
            const char rightHarfBlock = '\u2590';
            int index = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > data[index])
                {
                    index = i;
                }
            }



            char[,] map = new char[data.Length, data[index]];



            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data[index]; j++)
                {
                    map[i, j] = ' ';
                }
            }



            for (int x = 0; x < data.Length; x++)
            {
                for (int y = 0; y < data[x]; y++)
                {
                    map[x, y] = rightHarfBlock;
                }
            }



            Console.OutputEncoding = System.Text.Encoding.Unicode;
            if (balkenMode)
            {
                for (int x = 0; x < data.Length; x++)
                {
                    for (int y = 0; y < data[x]; y++)
                    {
                        Console.Write(map[x, y]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int y = data[index] - 1; y >= 0; y--)
                {
                    for (int x = 0; x < data.Length; x++)
                    {
                        Console.Write(map[x, y]);
                    }
                    Console.WriteLine();
                }
            }
        }

    }

}