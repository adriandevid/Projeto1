using Game.Interface;
using System;
namespace JogoOP
{
    class jogoFoda{
        public readonly joginterface _jogador1;
        public readonly joginterface _jogador2;
        public jogoFoda(joginterface jogador1, joginterface jogador2){
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }
        public void iniciarjogo(){
            _jogador1.chutar();
            _jogador2.chutar();
        }

}
}