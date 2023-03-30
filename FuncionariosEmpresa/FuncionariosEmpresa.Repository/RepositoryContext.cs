using FuncionariosEmpresa.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosEmpresa.Repository;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options) { }

    public DbSet<Empresa>? Empresas { get; set; }
    public DbSet<Funcionario>? Funcionarios { get; set; }
}
