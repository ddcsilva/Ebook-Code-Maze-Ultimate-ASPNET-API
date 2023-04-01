namespace FuncionariosEmpresa.Contracts;

public interface IRepositoryManager
{
    IEmpresaRepository Empresa { get; }
    IFuncionarioRepository Funcionario { get; }
    void Salvar();
}
