using System;

class CompanyAndManagerInfo
{
    static int readInts()
    {
        return int.Parse(Console.ReadLine());
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Pls give company info: name, adress, website, phone number, fax number.");
        string companyName = Console.ReadLine(), adress = Console.ReadLine(), website = Console.ReadLine();
        int companyNumber = readInts(), faxNumber = readInts();
        Console.WriteLine("Pls give manager info: first name, last name, age, phone number");
        string managerFName = Console.ReadLine(), managerLName = Console.ReadLine();
        int managerAge = readInts(), managerNumber = readInts() ;
        Console.WriteLine("Company:\nname - {0}\nadress - {1}",companyName, adress);
        Console.WriteLine("website - {0}\nphone number - {1}\nfax number - {2}", website, companyNumber, faxNumber);
        Console.WriteLine("Manager:\nfirst name - {0}\nlast name - {1}",managerFName,managerLName);
        Console.WriteLine("age - {0}\nphone number - {1}\n ",managerAge,managerNumber);
    }
}

