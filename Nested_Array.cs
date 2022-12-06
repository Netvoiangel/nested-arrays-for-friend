using System;

namespace nesArr
{
  class Program
  {
    static void Main(string[] args)
    {
        int size = 4;
        int[,] numbers = new int[size, size];  
        Random rnd = new Random();
        
        for (int i = 0; i < size; i ++)
        {
            for (int j = 0; j < size; j ++)
            {
                numbers[i,j] = rnd.Next(10, 99);
            }
        }
        
        for (int i = 0; i < size; i ++)
        {
            for (int j = 0; j < size; j ++)
            {
                Console.Write($"{numbers[i,j]} ");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine();
        
        for (int i = 0; i < size; i ++)
        {
            int sum = 0;
            
            for (int j = 0; j < size; j ++)
            {
                sum += numbers[i,j];
            }
            Console.WriteLine($"Строка {i}: {sum/size}");
        }
    }
  }
}