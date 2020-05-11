using GameTOP.Lib;
using System;

namespace GameTOP
{
    public class JogoFODA
    {
        public Jogador _jogador { get; }

        public JogoFODA(Jogador jogador)
        {
            _jogador = jogador;
        }
        public void IniciarJogo()
        {
            Console.Write("O jogo iniciou \n");
        }

        public void Chuta()
        {
            Console.Write(_jogador.Chuta());
        }
        public void Corre()
        {
            Console.Write(_jogador.Corre());
        }
        public void Passe()
        {
            Console.Write(_jogador.Passe());
        }
    }
}