using FuncionariosEmpresa.Contracts;
using FuncionariosEmpresa.Entities.Models;
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

    public IEnumerable<Empresa> ObterTodasEmpresas(bool rastrearAlteracoes)
    {
        try
        {
            var empresas = _repository.Empresa.ObterTodasEmpresas(rastrearAlteracoes);
            return empresas;
        }
        catch (Exception ex)
        {
            _logger.LogErro($"Algo deu erro no método da Service {nameof(ObterTodasEmpresas)} - {ex}");
            throw;
        }
    }
}
