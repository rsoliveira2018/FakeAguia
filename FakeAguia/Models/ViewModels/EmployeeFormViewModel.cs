using System.Collections.Generic;

namespace FakeAguia.Models.ViewModels
{
    public class EmployeeFormViewModel
    {
        public Employee Employee { get; set; }
        public ICollection<Plant> Plants { get; set; }
        public ICollection<Role> Roles { get; set; }
        public ICollection<Shift> Shifts { get; set; }
    }
}
