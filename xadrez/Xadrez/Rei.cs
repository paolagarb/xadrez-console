using System;
using tabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] Mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao Pos = new Posicao(0, 0);

            Pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
            }

            Pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
            }

            Pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
            }

            Pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
            }

            Pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
            }

            Pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
            }

            Pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
            }

            Pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
            }

            return Mat;
        }
    }
}
