using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgJogador
{
    public class Jogador
    {
        private string nome;
        private int idade;
        private int habilidade;
        private int camisa;
        private int gols;

        public Jogador(string pnome, int pidade, int phab, int pcamisa)
        {
            this.nome = pnome;
            this.idade = pidade;
            this.habilidade = phab;
            this.camisa = pcamisa;
        }

        public string getNome()
        {
            return nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public int getCamisa()
        {
            return camisa;
        }

        public int getHabilidade()
        {
            return habilidade;
        }

        public int Gols
        {
            get { return gols; }
            set { gols += value; }
        }

        public string getDescricao()
        {
            return "Nome " + this.getNome() +
                    "\tIdade: " + this.getIdade() +
                    "\tHabil.: " + this.getHabilidade() +
                    "\tCamisa: " + this.getCamisa() +
                    "\tGols: " + this.Gols;
        }
    }
}
