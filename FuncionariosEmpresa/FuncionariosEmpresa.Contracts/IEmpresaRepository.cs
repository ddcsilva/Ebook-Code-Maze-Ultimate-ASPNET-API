using FuncionariosEmpresa.Entities.Models;

namespace FuncionariosEmpresa.Contracts
{
    public interface IEmpresaRepository
    {
        IEnumerable<Empresa> ObterTodasEmpresas(bool rastrearAlteracoes);
    }
}
