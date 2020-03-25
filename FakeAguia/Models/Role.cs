using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FakeAguia.Models
{
    public class Role
    {
        [DisplayName("Código")]
        public int Id { get; private set; }
        [DisplayName("Cargo")]
        public string Name { get; private set; }
        [DisplayName("Colaboradores")]
        public List<Employee> Employees { get; private set; }

        public Role() { }

        public Role (int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
