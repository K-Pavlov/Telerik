using System;

namespace Ex05ArrayOfStrings
{
    class ArrayOfStrings
    {
        static void Main()
        {
            Console.WriteLine("Number of strings? ");
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = Console.ReadLine();
            }
            int minIndex = 0;
            string help = "";
            for (int i = 0; i < n - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j].Length < array[minIndex].Length)
                    {
                        minIndex = j;
                    }
                }
                help = array[minIndex];
                array[minIndex] = array[i];
                array[i] = help;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

