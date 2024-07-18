using System;
namespace Ex5;
class Program
{
    static void Main()
    {
        List<int> list = [34, 12, 5, 67, 23];

        System.Console.WriteLine("-----------Ordem Decrescente--------------");
        var listDescending = list.OrderByDescending(x => x).ToList();
        foreach (var item in listDescending)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("-----------Ordem Crescente--------------");
        var listAscending = list.OrderBy(x => x).ToList();
        foreach (var item in listAscending)
        {
            System.Console.WriteLine(item);
        }
    }
}