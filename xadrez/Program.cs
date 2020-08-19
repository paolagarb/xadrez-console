﻿using System;
using System.Linq.Expressions;
using System.Xml;
using tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
         
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

           
            /*
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());
            */
        }

    }
}
