using System.Text.Json.Serialization;

namespace Teste.API.Models;

public class Pessoa
{
    public int? PessoaId { get; set; }
    public string? Nome { get; set; }
    public string? SobreNome { get; set; }
    public DateTime? DataNasc { get; set; }
    //[JsonIgnore]
    public List<Endereco>? Enderecos { get; set; }
}
