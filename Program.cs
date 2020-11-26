using System;
using System.IO;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {

           string[] teste = new string[] {"1", "2", "3", "4", "5" };
           string selecionaPosicao = teste[1];

           Random rand = new Random();

           int posicaoAleatoria = rand.Next(teste.Length);

           string aleatorio = posicaoAleatoria.ToString();

           MeuMetodo(teste[1]);
           MeuMetodo(selecionaPosicao);
           MeuMetodo(aleatorio);

        }

        static void MeuMetodo(string parametro)
        {
            Console.WriteLine(parametro);
        }
    }
}
