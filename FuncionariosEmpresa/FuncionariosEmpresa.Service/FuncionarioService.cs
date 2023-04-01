using FuncionariosEmpresa.Contracts;
using FuncionariosEmpresa.Service.Contracts;

namespace FuncionariosEmpresa.Service;

public class FuncionarioService : IFuncionarioService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public FuncionarioService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }
}
