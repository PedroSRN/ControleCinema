using ControleCinema.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCinema.ConsoleApp.ModuloSala
{
    public class Sala : EntidadeBase
    {
        private readonly int _capacidadeSala;
        private readonly int _numeroAssentosDisponiveis;

        int Capacidade { get => _capacidadeSala; }
        int QtdAssentosDisponiveis { get => _numeroAssentosDisponiveis; }
        public Sala(int capacidadeSala,  int numeroAssentosDisponiveis)
        {
            _capacidadeSala = capacidadeSala;
            _numeroAssentosDisponiveis = numeroAssentosDisponiveis;
        }
        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "CapacidadeSala: " + Capacidade + Environment.NewLine +
                "Quantidade de Assentos Disponíveis na Sala " + QtdAssentosDisponiveis + Environment.NewLine;
                
        }
    }
}
