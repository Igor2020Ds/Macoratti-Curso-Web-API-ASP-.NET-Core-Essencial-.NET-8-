using Teste.API.Models;

namespace Teste.API.Repositorios.Contratos
{
    public interface IPessoaRepository
    {
        Task<(bool erro, string mensagem)> CadastrarPessoa(Pessoa pessoa);




    }
}
