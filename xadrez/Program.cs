using System;
using System.Linq.Expressions;
using System.Xml;
using tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
          
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                Tela.ImprimirTabuleiro(partida.Tab);
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
