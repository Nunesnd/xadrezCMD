using System;
using tabuleiro;

namespace xadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Console.WriteLine("Presione enter para fechar..........");
            Console.ReadLine();
        }
    }
}
