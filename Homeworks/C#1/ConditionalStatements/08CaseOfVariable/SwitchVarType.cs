using System;

class SwitchVarType
{
    static void userGiveInfo(string h)
    {
        Console.WriteLine("Now give me a {0}",h);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("What do you want int, double or string");
        string wish = Console.ReadLine();
        switch (wish)
        {
            case "int":
                userGiveInfo("int");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine(i + 1);
                break;
            case "double":
                userGiveInfo("double");
                double k = double.Parse(Console.ReadLine());
                Console.WriteLine(k + 1);
                break;
            case "string":
                userGiveInfo("string");
                string aString = Console.ReadLine();
                Console.WriteLine(aString + "*");
                break;
            default:
                Console.WriteLine("You did something wrong there");
                break;
        }
    }
}

