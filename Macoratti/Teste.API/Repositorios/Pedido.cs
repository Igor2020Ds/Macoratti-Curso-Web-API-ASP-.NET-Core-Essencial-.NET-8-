using Teste.API.ContextoDbApp;
using Teste.API.Models;
using Teste.API.Repositorios.Contratos;

namespace Teste.API.Repositorios
{
    public class PessoaRepository : IPessoaRepository
    {

		private readonly ContextoApp _contextoApp;
        public PessoaRepository(ContextoApp contextoApp)
        {

            _contextoApp = contextoApp;
            
        }
        public async Task<(bool erro, string mensagem)> CadastrarPessoa(Pessoa pessoa)
        {
			try
			{

                await _contextoApp.Pessoas.AddAsync(pessoa);
                int linhasinteiras = await  _contextoApp.SaveChangesAsync();

                if (linhasinteiras > 0)
                    return (false, $" Pessoa {pessoa.Nome} - pessoa.PessoaId");
                return (true, $" Pessoa {pessoa.Nome} nao cadastrada");


            
			}
			catch (Exception ex) 
			{

				return (true,  ex.Message);


				
			}
        }
    }
}
