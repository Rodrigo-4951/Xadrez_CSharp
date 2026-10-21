using System;
using xadrez;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro Tab {  get; private set; }
        private Cor Jogador;
        private int Turno;

        public bool Terminada {  get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            Jogador = Cor.Branco;
            colocarPecas();
            Terminada = false;
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.retirarPeca(origem);
            p.incrementarqtMovimento();
            Peca pecaCapturada = Tab.retirarPeca(destino);
            Tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            Tab.colocarPeca(new Torre(Cor.Branco, Tab), new Posicao(1, 1));
            Tab.colocarPeca(new Torre(Cor.Branco, Tab), new Posicao(3, 3));
            Tab.colocarPeca(new Rei(Cor.Ciano, Tab), new Posicao(5, 5));
        }
    }
}
