using FakeAguia.Data;
using FakeAguia.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FakeAguia.Services
{
    public class ShiftService
    {
        private readonly FakeAguiaContext _context;

        public ShiftService(FakeAguiaContext context)
        {
            _context = context;
        }

        public async Task<List<Shift>> FindAllAsync()
        {
            return await _context.Shift.OrderBy(x => x.Name).ToListAsync();
        }

        public List<Shift> FindAll()
        {
            return _context.Shift.OrderBy(x => x.Name).ToList();
        }

        public Shift FindById(int? shiftId)
        {
            return _context.Shift.Find(shiftId);
        }
    }
}
