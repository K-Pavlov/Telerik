using System;

class DescendingSort
{
    static float parseFloat()
    {
        return float.Parse(Console.ReadLine());
    }

    static void switcher(ref float numb, ref float numb1)
    {
        float temp = numb;
        numb = numb1;
        numb1 = temp;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Pls give 3 real numbers");
        float num1 = parseFloat(),
            num2 = parseFloat(),
            num3 = parseFloat();

        if (num3 > num2)
        {
            if (num3 > num1)
            {
                switcher(ref num1, ref num3);
            }
            else
            {
                switcher(ref num2, ref num3);
                if (num3 > num1)
                {
                    switcher(ref num1, ref num3);
                }
            }
        }
        else
        {
            if (num3 > num1)
            {
                switcher(ref num1, ref num3);
            }
            if (num2 > num1)
            {
                switcher(ref num1, ref num2);
            }
        }
        Console.WriteLine("Sorted : {0}~~{1}~~{2}",num1,num2,num3);
    }
}

