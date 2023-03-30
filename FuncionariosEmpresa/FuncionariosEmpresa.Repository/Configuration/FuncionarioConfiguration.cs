using FuncionariosEmpresa.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosEmpresa.Repository.Configuration;

public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
{
    public void Configure(EntityTypeBuilder<Funcionario> builder)
    {
        builder.HasData
        (
            new Funcionario
            {
                Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                Nome = "Sam Raiden",
                Idade = 26,
                Cargo = "Software developer",
                EmpresaId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
            },
            new Funcionario
            {
                Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                Nome = "Jana McLeaf",
                Idade = 30,
                Cargo = "Software developer",
                EmpresaId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
            },
            new Funcionario
            {
                Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                Nome = "Kane Miller",
                Idade = 35,
                Cargo = "Administrator",
                EmpresaId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
            }
        );
    }
}
