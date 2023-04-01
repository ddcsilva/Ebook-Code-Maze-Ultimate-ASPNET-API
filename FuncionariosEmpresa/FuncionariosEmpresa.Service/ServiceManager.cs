using FuncionariosEmpresa.Contracts;
using FuncionariosEmpresa.Service.Contracts;

namespace FuncionariosEmpresa.Service;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IEmpresaService> _empresaService;
    private readonly Lazy<IFuncionarioService> _funcionarioService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
    {
        _empresaService = new Lazy<IEmpresaService>(() => new EmpresaService(repositoryManager, logger));
        _funcionarioService = new Lazy<IFuncionarioService>(() => new FuncionarioService(repositoryManager, logger));
    }

    public IEmpresaService EmpresaService => _empresaService.Value;
    public IFuncionarioService FuncionarioService => _funcionarioService.Value;
}
