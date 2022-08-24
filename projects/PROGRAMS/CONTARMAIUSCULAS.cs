using System;

    class Program
    {
        static void Main(string[] args){
        string texto = "";
            do
            {
                texto = Console.ReadLine();
                if (texto.ToUpper() != "FIM")
                    Console.WriteLine($"Foram encontradas {ContaMaiusculas(texto)} letras maiúsculas no texto");
            } while(texto.ToUpper() != "FIM");
        }

        static int ContaMaiusculas(string texto)
        {
            int cont = 0;
            foreach (char c in texto)
            {
                if (Char.IsUpper(c))
                    cont++;
            }
            return cont;
        }
    }
