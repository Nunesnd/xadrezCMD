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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 4));
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(2, 3));

                tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(0, 3));
                tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(5, 2));
                tab.colocarPeca(new Rei(tab, Cor.Branco), new Posicao(2, 1));

                Tela.imprimirTabuleiro(tab);

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
