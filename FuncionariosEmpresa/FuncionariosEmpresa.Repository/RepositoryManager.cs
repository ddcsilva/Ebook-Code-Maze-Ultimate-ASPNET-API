using FuncionariosEmpresa.Contracts;

namespace FuncionariosEmpresa.Repository;

public class RepositoryManager
{
    private readonly RepositoryContext _context;
    private readonly Lazy<IEmpresaRepository> _empresaRepository;
    private readonly Lazy<IFuncionarioRepository> _funcionarioRepository;

    public RepositoryManager(RepositoryContext context)
    {
        _context = context;
        _empresaRepository = new Lazy<IEmpresaRepository>(() => new EmpresaRepository(context));
        _funcionarioRepository = new Lazy<IFuncionarioRepository>(() => new FuncionarioRepository(context));
    }

    public IEmpresaRepository Companhia => _empresaRepository.Value;
    public IFuncionarioRepository Funcionario => _funcionarioRepository.Value;

    public void Salvar()
    {
        _context.SaveChanges();
    }
}
