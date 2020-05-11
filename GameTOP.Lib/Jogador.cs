using System;


namespace GameTOP.Lib
{
    public class Jogador : iJogador
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }

        public Jogador(string nome, string posicao)
        {
            this.Nome = nome;
            this.Posicao = posicao;
        }

        public string Chuta()
        {
            return this.Nome + " chutou a bola \n";
        }
        public string Corre()
        {
            return this.Nome + " correu com a bola \n";
        }
        public string Passe()
        {
            return this.Nome + " passou a bola \n";
        }
    }

}