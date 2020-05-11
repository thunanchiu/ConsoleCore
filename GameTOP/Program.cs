using GameTOP.Lib;
using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador = new Jogador("Thun An", "Meia-Atacante");
            var jogo = new JogoFODA(jogador);
            jogo.IniciarJogo();
            jogo.Passe();
        }
    }


}
