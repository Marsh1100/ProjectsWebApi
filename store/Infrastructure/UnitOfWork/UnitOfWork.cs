using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.data;
using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork;


//IDisposable es una interfaz de .NET
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly StoreContext context;
    private CountryRepository _countries;
    public UnitOfWork(StoreContext _context)
    {
        context = _context;
    }

    public ICountry Countries
    {
        get{
            if(_countries == null){
                _countries = new CountryRepository(context);
            }
            return _countries;
        }
    }

    public void Dispose()
    {
        //throw new NotImplementedException();
        context.Dispose();
        
    }

    public  Task<int> SaveAsync()
    {
        throw new NotImplementedException();
    }
    
}
