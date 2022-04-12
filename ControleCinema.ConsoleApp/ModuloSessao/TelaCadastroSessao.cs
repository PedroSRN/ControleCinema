using ControleCinema.ConsoleApp.Compartilhado;
using ControleCinema.ConsoleApp.ModuloFilme;
using ControleCinema.ConsoleApp.ModuloIngresso;
using ControleCinema.ConsoleApp.ModuloSala;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCinema.ConsoleApp.ModuloSessao
{
    public class TelaCadastroSessao : TelaBase, ITelaCadastravel
    {
        private readonly IRepositorio<Sessao> _repositorioSessao;

        private readonly IRepositorio<Filme> _repositorioFilme;

        private readonly IRepositorio<Sala> _repositorioSala;

        private readonly Notificador _notificador;
        public TelaCadastroSessao(IRepositorio<Sessao> repositorioSessao, IRepositorio<Filme> repositorioFilme
            ,IRepositorio<Sala> repositorioSala, Notificador notificador) : base("Cadastro de Sessões")
        {
            _notificador = notificador;
            _repositorioSessao = repositorioSessao;
            _repositorioFilme = repositorioFilme;
            _repositorioSala = repositorioSala;

            /*_repositorioIngresso = repositorioIngresso;*/
            
        }
       
        public void Inserir()
        {
            Filme FilmeSelecionado = ObterFilme();

            if (FilmeSelecionado == null)
            {
                _notificador.ApresentarMensagem("Nenhum Filme selecionado", TipoMensagem.Erro);
                return;
            }

            MostrarTitulo("Cadastro de Sessões");
            Sessao novaSessao = ObterSessao();
            _repositorioSessao.Inserir(novaSessao);
            _notificador.ApresentarMensagem("Sessão cadastrado com sucesso!", TipoMensagem.Sucesso);
        }
        public void Editar()
        {
           
        }

        public void Excluir()
        {
            
        }

        public bool VisualizarRegistros(string tipoVisualizacao)
        {
            throw new NotImplementedException();
        }

        private Sessao ObterSessao()
        {
                Console.Write("Digite a data e hora da Sessão ");
                string dataEhora = Console.ReadLine();
                Console.Write("Digite ");
                int qtdLugares = Convert.ToInt32(Console.ReadLine());


            return new Sessao(dataEhora,qtdLugares,filme);
        }

        private Filme ObterFilme()
        {
            bool temFilmesDisponiveis = _telaCadastroFilme("Pesquisando");

            if (!temFilmesDisponiveis)
            {
                _notificador.ApresentarMensagem("Não há nenhum filme disponível para adicionar em sessão.", TipoMensagem.Atencao);
                return null;
            }

            Console.Write("Digite o número do filme para adiciona na sessão: ");
            int numeroDoFilme= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Filme filmeSelecionado = _repositorioFilme.SelecionarRegistro(x => x.numero == numeroDoFilme);

            return filmeSelecionado;
        }


    }
}
