using System;
using System.Runtime.ConstrainedExecution;
using xadrez;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {

                Tabuleiro board = new Tabuleiro(8, 8);

                board.colocarPeca(new Torre(Cor.Branco, board), new Posicao(0, 0));
                board.colocarPeca(new Torre(Cor.Branco, board), new Posicao(0, 7));
                board.colocarPeca(new Rei(Cor.Ciano, board), new Posicao(6, 7));

                Tela.imprimirTabuleiro(board);

                Console.ReadLine();
            }
            catch(TabuleiroException error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
