using System;
namespace Ex1;
class Program
{
    static void Main(string[] args)
    {
        List<int> list = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        foreach (int objeto in list)
        {
            System.Console.WriteLine(objeto);
        }
    }
}