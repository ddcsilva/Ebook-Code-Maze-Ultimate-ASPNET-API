using FuncionariosEmpresa.Contracts;
using FuncionariosEmpresa.Entities.Models;

namespace FuncionariosEmpresa.Repository;

public class FuncionarioRepository : RepositoryBase<Funcionario>, IFuncionarioRepository
{
	public FuncionarioRepository(RepositoryContext context) : base(context)
    {
	}
}
