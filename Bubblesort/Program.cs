using System;
namespace SortingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = {4,15,10,45};
           
            int temp;
            int numLength = number.Length;

             
            for (int i = 0; i < numLength - 1; i++)
            {
               
                for (int j = 0; j > (numLength - 1); j++)
                {
                    if (number[j + 1] > number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                       
                    }
                }
            }

            
            foreach (int num in number)
            {
                Console.Write("\t {0}", num);
            }
            Console.Read();
        }
    }
}