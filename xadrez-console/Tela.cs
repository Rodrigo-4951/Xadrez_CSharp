using System;
using System.Security.Cryptography.X509Certificates;
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
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Colunas; j++)
                {
                    if (board.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Tela.imprimirPeca(board.peca(i, j));
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void imprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branco)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(peca);
                Console.ForegroundColor= aux;
            }
        }
    }
}