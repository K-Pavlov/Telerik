using System;
using System.Collections.Generic;
using System.Linq;

class Neurons
{
    static List<int> BitTaker(int num)
    {
        List<int> bit = new List<int>() ;
        for (int i = 0; i < 32; i++)
        {
            bit.Add((num & (1 << i))>>i);
        }
        return bit;
    }

    static void Flag(List<int> bits)
    {
        int oneCount =bits.Count(i => i.Equals(1));
        int counter = 0;
        bool flag = false;

        for (int i = 0; i < 32; i++)
        {
            if (bits[i] == 1)
            {
                if (counter < oneCount)
                {
                    bits[i] = 0;
                    counter++;
                    flag = true;
                }
            }
            else if (counter == oneCount)
            {
                flag = false;
            }
            else if(counter < oneCount && flag == true)
            {               
                bits[i] = 1;              
            }           
        }

        for (int i = 31; i >= 0; i--)
        {
            Console.Write(bits[i]);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        List<int> bytes = new List<int>();
        List<int> nums = new List<int>();

        do
        {
            nums.Add(int.Parse(Console.ReadLine()));
        } while (nums[nums.Count - 1] != -1);

       foreach (int num in nums)
       {
           if (num != -1)
           {
               Flag(BitTaker(num));
           }
       }
    }
}

