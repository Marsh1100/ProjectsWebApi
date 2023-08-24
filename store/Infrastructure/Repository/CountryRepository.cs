using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;

namespace Infrastructure.Repository
{
    public class CountryRepository : GenericRepository<Country>, ICountry
    {
        _context = context;   
    }

    public override async Task<IEnumerable<Country>> GetAllAsync()
    {
        return await _context.Countries
            .Include(p => p.States)
            .ToListAsync();
    }

    public override async Task<Country> GetTaskAsync(int id)
    {
        return await _context.Countries
            .Include(p => p.States)
            .FirstOrDefaultAsync(p => p.Id == id);
    }
}