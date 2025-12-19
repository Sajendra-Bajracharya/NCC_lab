using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>
        {
            "Anisha",
            "Aleena",
            "Bob",
            "Amy",
            "Anita",
            "Suyog",
            "Amanda"
        };

        var result = names
            .Where(name => name.StartsWith("A") && name.Length > 4)
            .OrderBy(name => name);

        Console.WriteLine("Filtered Names:");
        foreach (var name in result)
        {
            Console.WriteLine(name);
        }
    }
}
