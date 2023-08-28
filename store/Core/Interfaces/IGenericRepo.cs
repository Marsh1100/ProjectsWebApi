
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

//La T es que se puede pasar como argumneto una colleción cualquiera
public interface IGenericRepo<T> where T : BaseEntity
{
    //Palabra reservada para representar la asincronía
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();

    IEnumerable<T> Find(Expression<Func<T, bool>> expression);

    Task<(int totalRecord, IEnumerable<T> records)> GetAllAsync(int pageIndex, int pageSize, string search);

    void Add(T entity);
    void AddRange(IEnumerable<T> entities);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
    void Update(T entity);
}
