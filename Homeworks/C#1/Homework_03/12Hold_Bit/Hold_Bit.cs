using System;

    class Hold_Bit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls give number, bit and value");
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int val = int.Parse(Console.ReadLine());
            int make_val = val << b;
            Console.WriteLine(val == 1 ? n | make_val : n & make_val);
        }
    }

