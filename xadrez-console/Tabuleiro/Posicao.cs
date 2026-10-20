using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.tabuleiro
{
    internal class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }


        public Posicao(int linha, int loluna)
        {
            Linha = linha;
            Coluna = loluna;
        }

        public override string ToString()
        {
            return Linha + ", " + Coluna;
        }
    }
}
