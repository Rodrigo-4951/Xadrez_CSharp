using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }

        public int qtMovimentos { get; protected set; }

        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qtMovimentos = 0;
        }

        public void incrementarqtMovimento()
        {
            qtMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
     
    }
}
