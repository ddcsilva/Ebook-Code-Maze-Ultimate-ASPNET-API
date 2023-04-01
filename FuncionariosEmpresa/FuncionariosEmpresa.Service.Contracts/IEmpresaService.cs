using FuncionariosEmpresa.Shared.DataTransferObjects;

namespace FuncionariosEmpresa.Service.Contracts;

public interface IEmpresaService
{
    IEnumerable<EmpresaDto> ObterTodasEmpresas(bool rastrearAlteracoes);
}
