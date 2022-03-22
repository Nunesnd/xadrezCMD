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

                while (!partida.terminada)
                {
                    try 
                    { 
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab);

                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando jogador " + partida.jogadorAtual);

                        Console.WriteLine();

                        Console.Write("Digite a posição de origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                        partida.validarPosicaoOrigem(origem);

                        //destaque dos movimentos possíveis da peça
                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movPossiveis();
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);


                        Console.WriteLine();
                        Console.Write("Digite a posição de destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.Read();
                    }
                }

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
