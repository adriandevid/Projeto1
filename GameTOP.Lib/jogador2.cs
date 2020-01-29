using Game.Interface;
using System;
namespace GameTOP.Lib
{
    public class jogador2 : joginterface
    {
        public void chutar()
        {
            Console.WriteLine("estas chutando");
        }

        public void correr()
        {
            Console.WriteLine("estas corriendo");
        }

        public void passe()
        {
            Console.WriteLine("estas passando");
        }
    }
}