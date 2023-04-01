using AutoMapper;
using FuncionariosEmpresa.Contracts;
using FuncionariosEmpresa.Service.Contracts;

namespace FuncionariosEmpresa.Service;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IEmpresaService> _empresaService;
    private readonly Lazy<IFuncionarioService> _funcionarioService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        _empresaService = new Lazy<IEmpresaService>(() => new EmpresaService(repositoryManager, logger, mapper));
        _funcionarioService = new Lazy<IFuncionarioService>(() => new FuncionarioService(repositoryManager, logger, mapper));
    }

    public IEmpresaService EmpresaService => _empresaService.Value;
    public IFuncionarioService FuncionarioService => _funcionarioService.Value;
}
