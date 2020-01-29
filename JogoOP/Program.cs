using GameTOP.Lib;
using Game.Interface;
using System;

namespace JogoOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new jogoFoda(new jogador1("adrian"), new jogador2());
            jogo.iniciarjogo();
            Console.WriteLine("ola");
        }
    }
}
