

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor {get; protected set; }
        public int qteMovim { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovim = 0;
        }
    }
}
