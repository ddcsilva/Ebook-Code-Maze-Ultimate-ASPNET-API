using AutoMapper;
using FuncionariosEmpresa.Contracts;
using FuncionariosEmpresa.Service.Contracts;
using FuncionariosEmpresa.Shared.DataTransferObjects;

namespace FuncionariosEmpresa.Service;

public class EmpresaService : IEmpresaService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public EmpresaService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public IEnumerable<EmpresaDto> ObterTodasEmpresas(bool rastrearAlteracoes)
    {
        var empresas = _repository.Empresa.ObterTodasEmpresas(rastrearAlteracoes);
        var empresasDto = _mapper.Map<IEnumerable<EmpresaDto>>(empresas);

        return empresasDto;
    }
}
