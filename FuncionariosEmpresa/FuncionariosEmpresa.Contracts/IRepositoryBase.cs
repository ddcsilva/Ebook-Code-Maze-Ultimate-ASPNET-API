using System.Linq.Expressions;

namespace FuncionariosEmpresa.Contracts;

public interface IRepositoryBase<T>
{
    IQueryable<T> BuscarTodos(bool rastrearAlteracoes);
    IQueryable<T> BuscarPorCondicao(Expression<Func<T, bool>> expression, bool rastrearAlteracoes);
    void Criar(T entity);
    void Atualizar(T entity);
    void Excluir(T entity);
}
