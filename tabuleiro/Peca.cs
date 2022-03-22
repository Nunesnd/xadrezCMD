namespace tabuleiro
{
    abstract class Peca
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

        public void incrementarQteMovimentos()
        {
            qteMovim++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movPossiveis();
            for (int i=0; i<tab.linhas; i++)
            {
                for (int j=0; j<tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        public bool podeMoverPara(Posicao pos)
        {
            return movPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movPossiveis();
    }
}
