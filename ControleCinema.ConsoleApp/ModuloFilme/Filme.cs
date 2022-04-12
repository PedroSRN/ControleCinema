using ControleCinema.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCinema.ConsoleApp.ModuloFilme
{
    public class Filme : EntidadeBase
    {
        private readonly double _duracao;
        private readonly string _titulo;

        public string Titulo { get => _titulo; }
        public double Duracao { get => _duracao; }
        public Filme(string filme, double duracao)
        {
            _titulo = filme;
            _duracao = duracao;
        }

        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Titulo: " + Titulo + Environment.NewLine +
                "Duração: " + Duracao + " horas" + Environment.NewLine;
        }
    }
}
