using System;
using xadrez_console.tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            // acima
            pos.definirValores(posicao.Linha - 1, posicao.Coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;

            // abaixo
            pos.definirValores(posicao.Linha + 1, posicao.Coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                 mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                 pos.Linha = pos.Linha + 1;

                    // direita
                    pos.definirValores(posicao.Linha, posicao.Coluna + 1);
                    while (tab.posicaoValida(pos) && podeMover(pos))
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                        if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                        {
                            break;
                        }
                        pos.Coluna = pos.Coluna + 1;



                        // esquerda
                        pos.definirValores(posicao.Linha, posicao.Coluna - 1);
                        while (tab.posicaoValida(pos) && podeMover(pos))
                        {
                            mat[pos.Linha, pos.Coluna] = true;
                            if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                            {
                                break;
                            }
                            pos.Coluna = pos.Coluna - 1;
                        }

                    }
                }
            }
            return mat;
        }
    }
}