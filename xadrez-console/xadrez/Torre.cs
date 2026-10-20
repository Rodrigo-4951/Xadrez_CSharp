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
    }
}