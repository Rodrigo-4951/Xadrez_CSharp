using System;
using System.Runtime.ConstrainedExecution;
using xadrez;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.Tab);

                    Console.WriteLine();
                    Console.WriteLine("Origem:");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.WriteLine("Destino:");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

                Console.ReadLine();
            }
            catch(TabuleiroException error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
