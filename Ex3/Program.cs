using System;
namespace Ex3;
class Program
{
    static void Main()
    {
        List<int> list = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        list.Remove(5);

        foreach (int objeto in list)
        {
            System.Console.WriteLine(objeto);
        }
    }
}