using FakeAguia.Data;
using FakeAguia.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FakeAguia.Services.Exceptions;

namespace FakeAguia.Services
{
    public class PlantService
    {
        private readonly FakeAguiaContext _context;

        public PlantService(FakeAguiaContext context)
        {
            _context = context;
        }

        public async Task<List<Plant>> FindAllAsync()
        {
            return await _context.Plant.Include(region => region.Region).OrderBy(x => x.Name).ToListAsync();
        }

        public List<Plant> FindAll()
        {
            return _context.Plant.Include(region => region.Region).OrderBy(x => x.Name).ToList();
        }

        public Plant FindById(int? plantId)
        {
            if (!_context.Plant.Any(x => x.Id == plantId))
            {
                throw new NotFoundException("Plant Id was not found!");
            }
            return _context.Plant.Find(plantId);
        }

        public void Update(Plant plant)
        {
            if (!_context.Plant.Any(x => x.Id == plant.Id))
            {
                throw new NotFoundException("Plant Id was not found!");
            }
            try
            {
                _context.Update(plant);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

        public void Insert(Plant plant)
        {
            _context.Add(plant);
            _context.SaveChanges();
        }
    }
}
