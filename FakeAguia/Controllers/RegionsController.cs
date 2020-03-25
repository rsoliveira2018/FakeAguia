using Microsoft.AspNetCore.Mvc;
using FakeAguia.Services;
using System.Threading.Tasks;

namespace FakeAguia.Controllers
{
    public class RegionsController : Controller
    {
        private readonly RegionService _regionService;

        public RegionsController(RegionService regionService)
        {
            _regionService = regionService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _regionService.FindAllAsync();
            return View(list);
        }
    }
}