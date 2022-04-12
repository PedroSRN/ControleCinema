using ControleCinema.ConsoleApp.Compartilhado;
using System;

namespace ControleCinema.ConsoleApp.ModuloFuncionario
{
    public class Funcionario : EntidadeBase
    {
        private readonly string _nome;
        private readonly string _login;
        private readonly string _senha;

        public string Nome { get => _nome; }

        public Funcionario(string nome, string login, string senha)
        {
            _nome = nome;
            _login = login;
            _senha = senha;
        }

        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Nome: " + Nome + Environment.NewLine;
        }
    }
}
