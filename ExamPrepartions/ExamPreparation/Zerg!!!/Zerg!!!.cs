using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PermutationFinder<T>
{
    public static int counter = 0;
    private T[] items;
    private Predicate<T[]> SuccessFunc;
    private bool success = false;
    private int itemsCount;

    public void Evaluate(T[] items, Predicate<T[]> SuccessFunc)
    {
        this.items = items;
        this.SuccessFunc = SuccessFunc;
        this.itemsCount = items.Count();
        Recurse(0);
    }

    private void Recurse(int index)
    {
        T tmp;

        if (index == itemsCount)
            success = SuccessFunc(items);
        else
        {
            for (int i = index; i < itemsCount; i++)
            {
                tmp = items[index];
                items[index] = items[i];
                items[i] = tmp;                 

                Recurse(index + 1);
                if (success)
                    break;

                tmp = items[index];
                items[index] = items[i];
                items[i] = tmp;
            }
        }
    }
    public int hi()
    {
        return counter;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(PermutationFinder<t>.hi());
    }
}