using FuncionariosEmpresa.Contracts;
using FuncionariosEmpresa.Entities.Models;

namespace FuncionariosEmpresa.Repository;

public class EmpresaRepository : RepositoryBase<Empresa>, IEmpresaRepository
{
	public EmpresaRepository(RepositoryContext context) : base(context)
    {
	}
}
