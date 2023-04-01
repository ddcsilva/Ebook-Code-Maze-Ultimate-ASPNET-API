using FuncionariosEmpresa.Entities.Models;

namespace FuncionariosEmpresa.Service.Contracts;

public interface IEmpresaService
{
    IEnumerable<Empresa> ObterTodasEmpresas(bool rastrearAlteracoes);
}
