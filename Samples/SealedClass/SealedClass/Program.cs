using System;
sealed class SealedClass
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        SealedClass slc = new SealedClass();
        int total = slc.Add(6, 4);
        Console.WriteLine("Sealed Class ");
        Console.WriteLine("Total = " + total.ToString());
    }
}