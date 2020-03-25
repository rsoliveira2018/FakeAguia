using Microsoft.AspNetCore.Mvc;
using FakeAguia.Services;
using System.Threading.Tasks;
using FakeAguia.Models;
using FakeAguia.Models.ViewModels;

namespace FakeAguia.Controllers
{
    public class PlantsController : Controller
    {
        private readonly PlantService _plantService;
        private readonly RegionService _regionService;

        public PlantsController(PlantService plantService, RegionService regionService)
        {
            _plantService = plantService;
            _regionService = regionService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _plantService.FindAllAsync();
            return View(list);
        }

        // GET ACTION Create()
        [HttpGet]
        //[ValidateAntiForgeryToken]
        public IActionResult Create()
        {
            Plant plant = new Plant();
            var regions = _regionService.FindAll();
            
            PlantFormViewModel plantFormViewModel = new PlantFormViewModel
            {
                Plant = plant,
                Regions = regions
            };

            return View(plantFormViewModel);
        }


        // POST ACTION Create()
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(Plant plant)
        {
            _plantService.Insert(plant);
            return RedirectToAction(nameof(Index));
        }

        // GET ACTION Edit()
        [HttpGet]
        //[ValidateAntiForgeryToken]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
                return NotFound();
            var plant = _plantService.FindById(Id);
            var regions = _regionService.FindAll();

            PlantFormViewModel plantFormViewModel = new PlantFormViewModel
            {
                Plant = plant,
                Regions = regions
            };

            return View(plantFormViewModel);
        }

        // POST ACTION Edit()
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Edit(Plant plant)
        {
            _plantService.Update(plant);
            return RedirectToAction(nameof(Index));
        }
    }
}