using System;
namespace Ex2;
class Program
{
    static void Main(string[] args)
    {
        List<string> nomes = ["Maria", "José", "Matheus", "Julia", "Paula"];
        foreach (string nome in nomes){
            Console.WriteLine(nome);
        }
    }
}
