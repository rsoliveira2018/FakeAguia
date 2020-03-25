using FakeAguia.Data;
using FakeAguia.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FakeAguia.Services
{
    public class RegionService
    {
        private readonly FakeAguiaContext _context;

        public RegionService(FakeAguiaContext context)
        {
            _context = context;
        }

        public async Task<List<Region>> FindAllAsync()
        {
            return await _context.Region.OrderBy(x => x.Name).ToListAsync();
        }

        public List<Region> FindAll()
        {
            return _context.Region.OrderBy(x => x.Name).ToList();
        }

    }
}
