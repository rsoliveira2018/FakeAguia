using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FakeAguia.Models
{
    public class Region
    {
        [DisplayName("Código")]
        public int Id { get; private set; }
        [DisplayName("Região")]
        public string Name { get; private set; }
        [DisplayName("Usinas")]
        public List<Plant> Plants { get; private set; }

        public Region() { }

        public Region(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
