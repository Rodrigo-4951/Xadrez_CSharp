using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas {  get; set; }
        private Peca[,] pecas;
        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[Linhas, Colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.Linha,pos.Coluna] = p;
            p.posicao = pos;
        }
    }
}
