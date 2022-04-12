using ControleCinema.ConsoleApp.Compartilhado;
using ControleCinema.ConsoleApp.ModuloFilme;
using ControleCinema.ConsoleApp.ModuloSala;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCinema.ConsoleApp.ModuloSessao
{
    public class Sessao : EntidadeBase
    {
        private readonly DateTime _dataEhora;
        private readonly Sala _qtdLugares;
        private readonly Filme _filme;
        private string DataEhora;
        private int QtdLugares;
        private string Filme;

        

        public Sessao(DateTime dataEhora, Sala qtdLugares, Filme filme)
        {
           _dataEhora = dataEhora;
           _qtdLugares = qtdLugares;
            _filme = filme;


        }

        public Sessao(string dataEhora, int qtdLugares, object filme)
        {
            this.dataEhora = dataEhora;
            this.qtdLugares = qtdLugares;
            this.filme = filme;
        }
    }
}
