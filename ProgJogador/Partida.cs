using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgJogador
{
    public class Partida
    {
        private DateTime data;
        private Time timeCasa;
        private Time timeVisitante;
        private int placarCasa;
        private int placarVisitante;

        public Partida(DateTime dataPartida, Time tcasa, Time tvisitante)
        {
            this.data = dataPartida;
            this.timeCasa = tcasa;
            this.timeVisitante = tvisitante;
            this.placarCasa = 0;
            this.placarVisitante = 0;
        }

        public int golCasa()
        {
            return placarCasa++;
        }

        public int golVisitante()
        {
            return placarVisitante++;
        }

        public string getPlacar()
        {
            if (this.placarCasa > this.placarVisitante)
            {
                this.timeCasa.Vitorias = 1;
                this.timeVisitante.Derrotas = 1;

                return "O vencedor da partida em " + this.data.ToString("dd-MM-yyyy") + " entre " + this.timeCasa.Nome +
                     " x " + this.timeVisitante.Nome +
                     " foi o time " + this.timeCasa.Nome + " com o placar de " + this.placarCasa.ToString() +
                     " a " + this.placarVisitante.ToString() + ".";
            }
            if (this.placarCasa == this.placarVisitante)
            {
                this.timeCasa.Empates = 1;
                this.timeVisitante.Empates = 1;

                return "Sem vencedor na partida em " + data.ToString("dd-MM-yyyy") +
                    " com o placar de " + placarCasa.ToString() +
                    " a " + placarVisitante.ToString() + ".";
            }
            else
            {
                this.timeVisitante.Vitorias = 1;
                this.timeCasa.Vitorias = 1;
                return "O vencedor da partida em " + this.data.ToString("dd-MM-yyyy") + " entre " + this.timeCasa.Nome +
                   " x " + this.timeVisitante.Nome +
                   " foi o time " + this.timeVisitante.Nome + " com o placar de " + this.placarVisitante.ToString() +
                   " a " + this.placarCasa.ToString() + ".";
            }
        }

        public void jogar()
        {
            Console.Write("Jogando..");

            golCasa(); golCasa(); golCasa(); golCasa(); golCasa(); golCasa(); golCasa(); golCasa(); golCasa();

            golVisitante();

        }
    }
}
