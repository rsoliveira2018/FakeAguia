using Microsoft.AspNetCore.Mvc;
using FakeAguia.Services;
using System.Threading.Tasks;

namespace FakeAguia.Controllers
{
    public class RolesController : Controller
    {
        private readonly RoleService _roleService;

        public RolesController(RoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _roleService.FindAllAsync();
            return View(list);
        }
    }
}