using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FuncionariosEmpresa.Entities.Models;

public class Funcionario
{
    [Column("FuncionarioId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O Nome do Funcionário é um campo obrigatório.")]
    [MaxLength(30, ErrorMessage = "O tamanho máximo do Nome do Funcionário é de 30 caracteres.")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "Idade é um campo obrigatório.")]
    public int Idade { get; set; }

    [Required(ErrorMessage = "Cargo é um campo obrigatório.")]
    [MaxLength(20, ErrorMessage = "O tamanho máximo do Cargo é de 20 caracteres.")]
    public string? Cargo { get; set; }

    [ForeignKey(nameof(Empresa))]
    public Guid CompanhiaId { get; set; }

    public Empresa? Empresa { get; set; }
}
