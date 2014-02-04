using System;

class Problem4
{
    static void Main() // VKUSNA MANDJA S GROZDE!!
    {
        int size = int.Parse(Console.ReadLine());
        int width = size * 3 - 1;
        int suicide = 0;

        string firstRow = new string('.', size + 1) + new string('*', size - 1) + new string('.', size + 1);

        Console.WriteLine(firstRow);
        for (byte topSide = 1, sideDots = (byte)(size - 1), middleDots = (byte)(size + 1); topSide < size - 1; topSide++, sideDots -= 2, middleDots += 4)
        {
            Console.WriteLine(new string('.', sideDots) + '*' + new string('.', middleDots) + '*' + new string('.', sideDots));
            if (size > 4 && sideDots == 1)
            {
                suicide = (size - 1) - (size - topSide + 1);
                for (byte times = 0; times < suicide; times++)
                    Console.WriteLine(new string('.', sideDots) + '*' + new string('.', middleDots) + '*' + new string('.', sideDots));
                break;
            }
        }
        Console.Write(".*");
        for (byte middle = 0; middle < width - 2; middle++)
        {
            if (middle % 2 == 0)
                Console.Write('@');
            else
                Console.Write('.');
        }
        Console.Write("*.");
        Console.WriteLine();
        Console.Write(".*");
        for (byte middle = 0; middle < width - 2; middle++)
        {
            if (middle % 2 == 0)
                Console.Write('.');
            else
                Console.Write('@');
        }
        Console.Write("*.");
        Console.WriteLine();
        for (byte topSide = 1, sideDots = 1, middleDots = (byte)(width - 2); topSide < size - 1; topSide++, sideDots += 2, middleDots -= 4)
        {
            if (size > 4 && sideDots == 1)
            {
                for (byte times = 0; times < suicide; times++)
                    Console.WriteLine(new string('.', sideDots) + '*' + new string('.', middleDots) + '*' + new string('.', sideDots));
            }
            Console.WriteLine(new string('.', sideDots) + '*' + new string('.', middleDots) + '*' + new string('.', sideDots));
            if (size > 4 && sideDots == size - 1)
                break;
        }
        Console.WriteLine(firstRow);
    }
}