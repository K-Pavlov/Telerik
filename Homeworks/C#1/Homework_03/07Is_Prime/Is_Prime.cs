using System;

class Is_Prime
{
    static void Main(string[] args)
    {
        int i;
        while (true)
        {
            Console.WriteLine("Pls give int <= 100");
            i = int.Parse(Console.ReadLine());
            if ( i <= 100 && i > 0) 
            {
                break;
            }
        }
        int counter = 0;
        for (int k = 1; k < i; k++)
        {
            counter +=  i % k == 0 ? 1 : 0;
            if (counter > 1) { break; }
        }

        Console.WriteLine(counter > 1 ? "Number is not prime" : "Number is prime" );
        
    }
}

