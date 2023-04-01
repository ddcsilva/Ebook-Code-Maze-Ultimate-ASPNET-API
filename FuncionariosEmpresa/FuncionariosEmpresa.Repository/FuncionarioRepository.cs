using FuncionariosEmpresa.Contracts;
using FuncionariosEmpresa.Entities.Models;

namespace FuncionariosEmpresa.Repository;

public class FuncionarioRepository : RepositoryBase<Empresa>, IEmpresaRepository
{
	public FuncionarioRepository(RepositoryContext context) : base(context)
    {
	}
}
