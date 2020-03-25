using Microsoft.AspNetCore.Mvc;
using FakeAguia.Services;
using System.Threading.Tasks;
using FakeAguia.Models;
using FakeAguia.Models.ViewModels;
using FakeAguia.Services.Exceptions;

namespace FakeAguia.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeService _employeeService;
        private readonly RoleService _roleService;
        private readonly ShiftService _shiftService;
        private readonly PlantService _plantService;


        public EmployeesController(
            EmployeeService employeeService,
            RoleService roleService,
            ShiftService shiftService,
            PlantService plantService
            )
        {
            _employeeService = employeeService;
            _roleService = roleService;
            _shiftService = shiftService;
            _plantService = plantService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _employeeService.FindAllAsync();
            return View(list);
        }

        // GET ACTION Create()
        [HttpGet]
        //[ValidateAntiForgeryToken]
        public IActionResult Create()
        {
            Employee employee = new Employee();
            var plants = _plantService.FindAll();
            var roles = _roleService.FindAll();
            var shifts = _shiftService.FindAll();
            EmployeeFormViewModel employeeFormViewModel = new EmployeeFormViewModel
            {
                Employee = employee,
                Plants = plants,
                Roles = roles,
                Shifts = shifts
            };

            return View(employeeFormViewModel);
        }

        
        // POST ACTION Create()
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            _employeeService.Insert(employee);
            return RedirectToAction(nameof(Index));
        }

        // GET ACTION Edit()
        [HttpGet]
        //[ValidateAntiForgeryToken]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
                return NotFound();
            var employee = _employeeService.FindById(Id);
            var plants = _plantService.FindAll();
            var roles = _roleService.FindAll();
            var shifts = _shiftService.FindAll();

            EmployeeFormViewModel employeeFormViewModel = new EmployeeFormViewModel
            {
                Employee = employee,
                Plants = plants,
                Roles = roles,
                Shifts = shifts
            };

            return View(employeeFormViewModel);
        }

        
        // POST ACTION Edit()
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Edit(Employee employee)
        {
            _employeeService.Update(employee);
            return RedirectToAction(nameof(Index));
        }
        
    }
}