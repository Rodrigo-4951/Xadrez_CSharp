using System;
using System.Xml;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro board)
        {
            for (int i = 0; i < board.Linhas; i++)
            {
                for (int j = 0; j < board.Colunas; j++)
                {
                    if(board.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
