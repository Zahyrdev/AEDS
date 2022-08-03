using System;

class Program
{
    static void Main(string[] args){
        double R, V;
        Console.WriteLine("Entre com o parâmetro: ");
        R = double.Parse(Console.ReadLine());
        Console.WriteLine(Lefuncao(R));

        int Lefuncao(double V){
            return (4 * 3.14 * Math.Pow(V, 3)) / 3;
        }
    }
}
