using FuncionariosEmpresa.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FuncionariosEmpresa.Repository;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected RepositoryContext Context;

    public RepositoryBase(RepositoryContext context)
    {
        Context = context;
    }

    public IQueryable<T> BuscarTodos(bool rastrearAlteracoes)
    {
        return !rastrearAlteracoes ?
            Context.Set<T>().AsNoTracking() :
            Context.Set<T>();
    }

    public IQueryable<T> BuscarPorCondicao(Expression<Func<T, bool>> expression, bool rastrearAlteracoes)
    {
        return !rastrearAlteracoes ?
            Context.Set<T>().Where(expression).AsNoTracking() :
            Context.Set<T>().Where(expression);
    }

    public void Criar(T entity)
    {
        Context.Set<T>().Add(entity);
    }

    public void Atualizar(T entity)
    {
        Context.Set<T>().Update(entity);
    }

    public void Excluir(T entity)
    {
        Context.Set<T>().Remove(entity);
    }
}
