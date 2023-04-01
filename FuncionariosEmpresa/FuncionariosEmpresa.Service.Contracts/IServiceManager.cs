namespace FuncionariosEmpresa.Service.Contracts;

public interface IServiceManager
{
    IEmpresaService EmpresaService { get; }
    IFuncionarioService FuncionarioService { get; }
}
