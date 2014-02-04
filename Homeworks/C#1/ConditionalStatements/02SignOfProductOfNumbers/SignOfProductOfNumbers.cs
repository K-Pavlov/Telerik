using System;

    class SignOfProductOfNumbers
    {
        static sbyte checkIfPositive()
        {
            float i = float.Parse(Console.ReadLine());
            if (i < 0)
            {
                return 0;
            }
            else if (i == 0)
            {
                return -4;
            }
            else
            {
                return 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Pls give 3 real numbers");
            int num1 = checkIfPositive(), 
                num2 = checkIfPositive(),
                num3 = checkIfPositive();
            int sign = num1 + num2 + num3;
            
            if(sign < 0)
            {
                Console.WriteLine("It's 0!");
            }
            else if (sign == 0 || sign == 2)
            {
                Console.WriteLine("The product is negative.");
            }
            else
            {
                Console.WriteLine("The product is positive.");                
            }
        }
    }

