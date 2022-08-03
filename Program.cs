using System;

class Program
{
    static void Main(string[] args){
        
    }

    public void PrimeiraQuestao(){
        double R, V;
        Console.WriteLine("Entre com o parâmetro: ");
        R = double.Parse(Console.ReadLine());
        Console.WriteLine(Lefuncao(R));

        double Lefuncao(double V){
            return (4 * 3.14 * Math.Pow(V, 3)) / 3;
        }
    }

    public void SegundaQuestao(){
        double R, V;
        Console.WriteLine("Entre com o parâmetro: ");
        R = double.Parse(Console.ReadLine());
        Console.WriteLine(Lefuncao(R));

        double Lefuncao(double V)
        {
            V = Math.Floor(V);
            Console.WriteLine(V);
            return (4 * 3.14 * Math.Pow(V, 3)) / 3;
        }
    }

        public void TerceiraQuestao(){
        float [] A = new float [10];
        LeVetor(A);
        
        }
    }
