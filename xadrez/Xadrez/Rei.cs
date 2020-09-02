﻿using tabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        private PartidaDeXadrez Partida;

        public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            Partida = partida;
        }

        public override string ToString()
        {
            return "R";
        }

        private bool TesteTorreParaRoque(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p != null && p is Torre && p.Cor == Cor && p.QteMovimentos == 0;
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

            /* Roque */
            if (QteMovimentos==0 && !Partida.Xeque)
            {
                Posicao posT1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);
                if (TesteTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);
                    if (Tab.Peca(p1) == null && Tab.Peca(p2) == null)
                    {
                        Mat[Posicao.Linha, Posicao.Coluna + 2] = true;
                    }
                }

                Posicao posT2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
                if (TesteTorreParaRoque(posT2))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);
                    if (Tab.Peca(p1) == null && Tab.Peca(p2) == null && Tab.Peca(p3) == null)
                    {
                        Mat[Posicao.Linha, Posicao.Coluna - 2] = true;
                    }
                }
            }
            return Mat;
        }
    }
}
