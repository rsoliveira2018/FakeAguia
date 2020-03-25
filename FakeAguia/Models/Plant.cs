using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FakeAguia.Models
{
    public class Plant
    {
        [DisplayName("Código")]
        public int Id { get; set; }
        [DisplayName("Usina")]
        public string Name { get; set; }
        [DisplayName("Região")]
        public Region Region { get; set; }

        public int RegionId { get; set; }


        public Plant() { }

        public Plant(int id, string name, Region region)
        {
            Id = id;
            Name = name;
            Region = region;
        }
    }
}
