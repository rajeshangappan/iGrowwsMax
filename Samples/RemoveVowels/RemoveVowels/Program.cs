using System;
using System.Text.RegularExpressions;

class Program
{
    static String remVowel(String str)
    {
        str = Regex.Replace(str, "[aeiouAEIOU]", "");
        return str;
    }
    public static void Main()
    {
        Console.WriteLine("Enter the string:");
        String str =Console.ReadLine();
        Console.WriteLine(remVowel(str));
    }
}
