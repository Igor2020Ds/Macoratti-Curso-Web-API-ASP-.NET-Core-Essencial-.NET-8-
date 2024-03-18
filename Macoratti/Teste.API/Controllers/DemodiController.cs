using Microsoft.AspNetCore.Mvc;
using Teste.API.Models;
using Teste.API.Repositorios.Contratos;

namespace Teste.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class PessoaController : ControllerBase
{

    private readonly IPessoaRepository _pessoaRepository;
    public PessoaController(IPessoaRepository pessoaRepository)
    {
        _pessoaRepository = pessoaRepository;
    }


    [HttpPost]
    public async Task<IActionResult> CadastrarPessoa(Pessoa pessoa)
    {

        var (erro,mensagem) = await _pessoaRepository.CadastrarPessoa(pessoa);

    
        return erro ? BadRequest(mensagem) : Ok(mensagem); 
    }
}
