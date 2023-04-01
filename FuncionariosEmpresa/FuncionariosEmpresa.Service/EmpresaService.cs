using FuncionariosEmpresa.Contracts;
using FuncionariosEmpresa.Service.Contracts;

namespace FuncionariosEmpresa.Service;

public class EmpresaService : IEmpresaService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public EmpresaService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }
}
