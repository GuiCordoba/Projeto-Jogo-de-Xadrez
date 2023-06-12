using System;
using System.Data.Common;
using System.Xml;
using tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Console.WriteLine();
            Tela.imprimirTabuleiro(tab);
            
        }

        
    }
}