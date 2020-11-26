using System;
using System.IO;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {

           string[] teste = new string[] {
           "1", "2", "3", "4", "5", "6",
           "7", "8", "9", "10", "11", "12",
           "13", "14", "15", "16", "17", "18" };
           
           string selecionaPosicao = teste[7];

           Random rand = new Random();

           int posicaoAleatoria = rand.Next(teste.Length);

           string aleatorio = posicaoAleatoria.ToString();

           MeuMetodo(teste[5]);
           MeuMetodo(selecionaPosicao);
           MeuMetodo(aleatorio);

        }

        static void MeuMetodo(string parametro)
        {
            Console.WriteLine(parametro);
        }
    }
}
