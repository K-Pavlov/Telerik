using System;

class Matrix
{ 
    
    static void Main(string[] args)
    {
        
        Console.WriteLine("What matrix do you want?");
        int matrixSize = int.Parse(Console.ReadLine());
        for (int i = 1; i <= matrixSize; i++)
        {
            for (int k = 0; k < matrixSize; k++)
            {
                Console.Write(i + k + "|");
            }
            Console.WriteLine();
        }   

    }
}

