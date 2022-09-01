
using System;

class Program
{
    static void Main(string[] args)

    {
        int[,] mas = new int[3,4] { {1,4,7,2},
                                    {5,9,2,3},
                                    {8,4,2,4}};
 
            for (int i = 0; i < 4; i++) 
            {
                float average = 0;
                
                for (int j = 0; j < 3; j++)
                {
                    average += mas[j, i];
                    
                    
                }
                Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {Math.Round(average/3, 2)}");
                
            }
    }
}
