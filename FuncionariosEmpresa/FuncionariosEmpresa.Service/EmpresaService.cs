using FuncionariosEmpresa.Contracts;
using FuncionariosEmpresa.Entities.Models;
using FuncionariosEmpresa.Service.Contracts;
using FuncionariosEmpresa.Shared.DataTransferObjects;

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

    public IEnumerable<EmpresaDto> ObterTodasEmpresas(bool rastrearAlteracoes)
    {
        try
        {
            var empresas = _repository.Empresa.ObterTodasEmpresas(rastrearAlteracoes);
            var empresasDto = empresas.Select(e => 
                new EmpresaDto(e.Id, e.Nome ?? "", string.Join(' ', e.Endereco, e.Pais))).ToList();

            return empresasDto;
        }
        catch (Exception ex)
        {
            _logger.LogErro($"Algo deu erro no método da Service {nameof(ObterTodasEmpresas)} - {ex}");
            throw;
        }
    }
}
