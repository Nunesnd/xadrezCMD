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
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 9));
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(2, 3));

                Tela.imprimirTabuleiro(tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Presione enter para fechar..........");
            Console.ReadLine();
        }
    }
}
