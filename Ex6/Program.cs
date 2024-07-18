using System;
namespace Ex6;
class Program{
    static void Main(){
        List<string> nomes = ["Maria", "José", "Matheus", "Julia", "Paula"];
        nomes.Insert(3, "Ana");
        foreach (string nome in nomes){
            Console.WriteLine(nome);
        }
    }
}