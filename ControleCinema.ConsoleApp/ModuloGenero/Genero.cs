using ControleCinema.ConsoleApp.Compartilhado;
using System;

namespace ControleCinema.ConsoleApp.ModuloGenero
{
    public class Genero : EntidadeBase
    {
        public string Descricao { get; set; }

        public Genero(string descricao)
        {
            Descricao = descricao;
        }

        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Descrição do Gênero: " + Descricao + Environment.NewLine;
        }
    }
}
