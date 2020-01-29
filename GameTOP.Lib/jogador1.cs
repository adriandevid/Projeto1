using Game.Interface;
using System;

namespace GameTOP.Lib
{
    public class jogador1 : joginterface{
        public readonly string nome;

        public jogador1(string _nome){
            this.nome = _nome;
        }
        public void chutar(){
            Console.WriteLine($"{nome} esta chutando");
        }
        public void correr(){
            Console.WriteLine($"{nome} esta correndo");
        }
        public void passe(){
            Console.WriteLine($"{nome} esta passsando");
        }
    }
}