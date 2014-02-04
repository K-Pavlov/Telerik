using System;

class CalcPI
{
    static void Main(string[] args)
    {
        Console.WriteLine("Want an accurate number?");
        System.Threading.Thread.Sleep(2000);
        decimal strangeNum = 1.0M;
        for (decimal i = 2.0M; i < 6000 + 2; i++)
        {
            if( i % 2 == 0 )
            {
                strangeNum += 1 / i ;
            }
            else
            {
                strangeNum -= 1/ i;
            }
        }
        Console.WriteLine("Here you go, num = {0:0.000}!",strangeNum);
    }
}

