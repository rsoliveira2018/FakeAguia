using FakeAguia.Data;
using FakeAguia.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FakeAguia.Services.Exceptions;

namespace FakeAguia.Services
{
    public class EmployeeService
    {
        private readonly FakeAguiaContext _context;

        public EmployeeService(FakeAguiaContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> FindAllAsync()
        {
            return await _context.Employee.Include(plant => plant.Plant).Include(role => role.Role).Include(shift => shift.Shift).OrderBy(x => x.Name).ToListAsync();
        }

        public void Insert(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            if(!_context.Employee.Any(x => x.Id == employee.Id))
            {
                throw new NotFoundException("Employee Id was not found!");
            }
            try
            {
                _context.Update(employee);
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
            
        }

        public Employee FindById(int? employeeId)
        {
            if (!_context.Employee.Any(x => x.Id == employeeId))
            {
                throw new NotFoundException("Employee Id was not found!");
            }
            return _context.Employee.Find(employeeId);
        }
    }
}
