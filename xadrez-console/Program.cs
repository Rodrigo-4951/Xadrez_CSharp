using System;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro board = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(board);

            Console.ReadLine();
        }
    }
}
