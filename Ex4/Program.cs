using System;
namespace Ex4;
class Program{
    static void Main(){
        List<double> list = [ 1.5, 2.3, 4.7, 6.8, 9.1];
        
        if (list.Exists(x => x == 4.7)){
            Console.WriteLine("O número esta presente na lista!");
        }else{
            System.Console.WriteLine("Este número não está nesta lista!");
        }
    }
}