using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinSearch
{
    static int Main(string[] args)
    {
        Console.WriteLine(
            "Pls give the array size");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(
            "Pls give what is the cap");
        int K = int.Parse(Console.ReadLine());
        Console.WriteLine(
            "Pls give array elements");
        int[] theArr = new int[N];
        int element = 0;
        string[] allElements = Console.ReadLine().Split(' ');
        foreach (string s in allElements)
        {
            if (element == N)
            {
                Console.WriteLine(
                    "You so funny");
                return 1;
            }
            theArr[element] = int.Parse(s);
            element++;
        }
        Array.Sort(theArr);
        int res = 0;
        if (theArr[0] > K)
        {
            Console.WriteLine(
                "There is no number that is less than or equal to k.");
        }
        else
        {
            element = Array.BinarySearch(theArr, K);
            if (element >= 0)
            {
                res = theArr[element];
            }
            else
            {
                res = theArr[~element - 1];
            }
            Console.WriteLine(
                "The biggest num is below the cap or equal to it is {0}",res);
        }
        return 0;
    }
}

