using FuncionariosEmpresa.Entities.Models;
using FuncionariosEmpresa.Repository.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosEmpresa.Repository;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EmpresaConfiguration());
        modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
    }

    public DbSet<Empresa>? Empresas { get; set; }
    public DbSet<Funcionario>? Funcionarios { get; set; }
}
