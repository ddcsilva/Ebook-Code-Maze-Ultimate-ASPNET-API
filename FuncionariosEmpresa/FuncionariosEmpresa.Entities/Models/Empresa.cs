using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FuncionariosEmpresa.Entities.Models;

public class Empresa
{
    [Column("EmpresaId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O Nome da Empresa é um campo obrigatório.")]
    [MaxLength(60, ErrorMessage = "O tamanho máximo do Nome da Empresa é de 60 caracteres.")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "O Endereço da Empresa é um campo obrigatório.")]
    [MaxLength(60, ErrorMessage = "O tamanho máximo do Endereço da Empresa é de 60 caracteres.")]
    public string? Endereco { get; set; }

    public string? Pais { get; set; }

    public ICollection<Funcionario>? Funcionarios { get; set; }
}
