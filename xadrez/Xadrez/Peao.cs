﻿using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Xadrez.Xadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "P";
        }

        private bool ExisteInimigo(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p != null && p.Cor != Cor;
        }

        private bool Livre(Posicao pos)
        {
            return Tab.Peca(pos) == null;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] Mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao Pos = new Posicao(0, 0);

            if (Cor == Cor.Branca)
            {
                Pos.DefinirValores(Pos.Linha - 1, Pos.Coluna);
                if (Tab.PosicaoValida(Pos) && Livre(Pos))
                {
                    Mat[Pos.Linha, Pos.Coluna] = true;
                }
                Pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna);
                if (Tab.PosicaoValida(Pos) && Livre(Pos) && QteMovimentos == 0)
                {
                    Mat[Pos.Linha, Pos.Coluna] = true;
                }
                Pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tab.PosicaoValida(Pos) && ExisteInimigo(Pos))
                {
                    Mat[Pos.Linha, Pos.Coluna] = true;
                }
                Pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tab.PosicaoValida(Pos) && ExisteInimigo(Pos))
                {
                    Mat[Pos.Linha, Pos.Coluna] = true;
                }
            } else
            {
                Pos.DefinirValores(Pos.Linha + 1, Pos.Coluna);
                if (Tab.PosicaoValida(Pos) && Livre(Pos))
                {
                    Mat[Pos.Linha, Pos.Coluna] = true;
                }
                Pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna);
                if (Tab.PosicaoValida(Pos) && Livre(Pos) && QteMovimentos == 0)
                {
                    Mat[Pos.Linha, Pos.Coluna] = true;
                }
                Pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tab.PosicaoValida(Pos) && ExisteInimigo(Pos))
                {
                    Mat[Pos.Linha, Pos.Coluna] = true;
                }
                Pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tab.PosicaoValida(Pos) && ExisteInimigo(Pos))
                {
                    Mat[Pos.Linha, Pos.Coluna] = true;
                }
            }
            return Mat;
        }
    }
}

