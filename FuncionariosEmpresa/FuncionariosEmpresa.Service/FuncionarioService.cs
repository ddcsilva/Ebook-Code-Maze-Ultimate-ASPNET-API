using AutoMapper;
using FuncionariosEmpresa.Contracts;
using FuncionariosEmpresa.Service.Contracts;

namespace FuncionariosEmpresa.Service;

public class FuncionarioService : IFuncionarioService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public FuncionarioService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }
}
