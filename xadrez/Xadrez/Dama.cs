using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Xadrez.Xadrez
{
    class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "D";
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

            Pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
                if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                {
                    break;
                }
                Pos.DefinirValores(Pos.Linha, Pos.Coluna - 1);
            }

            Pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
                if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                {
                    break;
                }
                Pos.DefinirValores(Pos.Linha, Pos.Coluna + 1);
            }


            Pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
                if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                {
                    break;
                }
                Pos.DefinirValores(Pos.Linha - 1, Pos.Coluna);
            }

            Pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
                if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                {
                    break;
                }
                Pos.DefinirValores(Pos.Linha + 1, Pos.Coluna);
            }

            Pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
                if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                {
                    break;
                }
                Pos.DefinirValores(Pos.Linha - 1, Pos.Coluna - 1);
            }

            Pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
                if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                {
                    break;
                }
                Pos.DefinirValores(Pos.Linha - 1, Pos.Coluna + 1);
            }

            Pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
                if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                {
                    break;
                }
                Pos.DefinirValores(Pos.Linha + 1, Pos.Coluna + 1);
            }

            Pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(Pos) && PodeMover(Pos))
            {
                Mat[Pos.Linha, Pos.Coluna] = true;
                if (Tab.Peca(Pos) != null && Tab.Peca(Pos).Cor != Cor)
                {
                    break;
                }
                Pos.DefinirValores(Pos.Linha + 1, Pos.Coluna - 1);
            }

            return Mat;
        }
    }
}
