using tabuleiro;

namespace xadrez
{
    public class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8,8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('a',8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(5,4));

            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0,2));
            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(5,3));
        }
    }
}