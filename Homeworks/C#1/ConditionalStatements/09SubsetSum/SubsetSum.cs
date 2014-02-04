using System;

class SubsetSum
{
    static int parseInt()
    {
        return int.Parse(Console.ReadLine());
    }

    static int Main(string[] args)
    {
        int one = parseInt(),
            two = parseInt(),
            three = parseInt(),
            four = parseInt(),
            five = parseInt(),
            sum = 0;
        
        
        for (int i = 0; i < 2; i++)
        {
            for (int k = 0; k < 2; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int p = 0; p < 2; p++)
                    {
                        for (int q = 0; q < 2; q++)
                        {
                            if ((i != 0) || (k != 0) || (j != 0) || (p != 0) || (q != 0))
                            {
                                sum = one * i + two * k + three * j + four * p + five * q;
                                if (sum == 0)
                                {
                                    Console.WriteLine("At least one subset is zero!");
                                    return 0;
                                }
                            }
                                
                        }
                    }   
                }
            }
        }
        Console.WriteLine("No subset is zero");
        return 0;
    }
 }


