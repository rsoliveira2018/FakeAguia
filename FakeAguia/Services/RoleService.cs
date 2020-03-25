using FakeAguia.Data;
using FakeAguia.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FakeAguia.Services
{
    public class RoleService
    {
        private readonly FakeAguiaContext _context;

        public RoleService(FakeAguiaContext context)
        {
            _context = context;
        }

        public async Task<List<Role>> FindAllAsync()
        {
            return await _context.Role.OrderBy(x => x.Name).ToListAsync();
        }

        public List<Role> FindAll()
        {
            return _context.Role.OrderBy(x => x.Name).ToList();
        }

        public Role FindById(int? roleId)
        {
            return _context.Role.Find(roleId);
        }
    }
}
