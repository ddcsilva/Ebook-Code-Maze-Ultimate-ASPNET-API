using FuncionariosEmpresa.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosEmpresa.Repository.Configuration;

public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
{
    public void Configure(EntityTypeBuilder<Empresa> builder)
    {
        builder.HasData
        (
            new Empresa
            {
                Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                Nome = "IT_Solutions Ltd",
                Endereco = "583 Wall Dr. Gwynn Oak, MD 21207",
                Pais = "USA"
            },
            new Empresa
            {
                Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                Nome = "Admin_Solutions Ltd",
                Endereco = "312 Forest Avenue, BF 923",
                Pais = "USA"
            }
        );
    }
}
