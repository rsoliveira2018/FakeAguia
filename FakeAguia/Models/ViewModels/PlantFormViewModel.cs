using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeAguia.Models.ViewModels
{
    public class PlantFormViewModel
    {
        public Plant Plant { get; set; }
        public ICollection<Region> Regions { get; set; }
    }
}
