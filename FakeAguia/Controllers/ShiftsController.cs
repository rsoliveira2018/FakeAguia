using Microsoft.AspNetCore.Mvc;
using FakeAguia.Services;
using System.Threading.Tasks;

namespace FakeAguia.Controllers
{
    public class ShiftsController : Controller
    {
        private readonly ShiftService _shiftService;

        public ShiftsController(ShiftService shiftService)
        {
            _shiftService = shiftService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _shiftService.FindAllAsync();
            return View(list);
        }
    }
}