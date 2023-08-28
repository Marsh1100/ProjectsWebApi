using Core.Entities;

namespace Core.Interfaces
{
    public interface ICountry : IGenericRepo<Country>
    {
        Task ToListAsync();
    }
}