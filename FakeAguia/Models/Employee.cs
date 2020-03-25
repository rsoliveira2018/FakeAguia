using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FakeAguia.Models
{
    public class Employee
    {
        [DisplayName("Código")]
        public int Id { get; set; }
        [DisplayName("Colaborador")]
        public string Name { get; set; }
        [DisplayName("Usina")]
        public Plant Plant { get; set; }
        [DisplayName("Perfil")]
        public Profile Profile { get; set; }
        [DisplayName("Cargo")]
        public Role Role { get; set; }
        [DisplayName("Turno")]
        public Shift Shift { get; set; }

        public int PlantId { get; set; }
        public int ShiftId { get; set; }
        public int RoleId { get; set; }

        public Employee() { }

        public Employee(int id, string name, Plant plant, Role role, Profile profile, Shift shift)
        {
            Id = id;
            Name = name;
            Plant = plant;
            Role = role;
            Profile = profile;
            Shift = shift;
        }
    }
}
