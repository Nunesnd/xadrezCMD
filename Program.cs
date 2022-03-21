using System;
using tabuleiro;
using xadrez;

namespace xadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try { 
                PartidaDeXadrez partida = new PartidaDeXadrez(); 

                Tela.imprimirTabuleiro(partida.tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            /*

            PosicaoXadrez pos = new PosicaoXadrez('c', 4);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            */

            Console.WriteLine("Presione enter para fechar..........");
            Console.ReadLine();
        }
    }
}
