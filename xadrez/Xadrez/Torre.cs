﻿using System;
using tabuleiro;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "T";
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] Mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao Pos = new Posicao(0, 0);

            Pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
                if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                {
                    break;
                }
                Pos.Linha = Pos.Linha - 1;
            }

            Pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
                if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                {
                    break;
                }
                Pos.Linha = Pos.Linha + 1;
            }


            Pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
                if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                {
                    break;
                }
                Pos.Linha = Pos.Coluna + 1;
            }

            Pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
                if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                {
                    break;
                }
                Pos.Linha = Pos.Coluna - 1;
            }

            return Mat;
        }
    }
}
