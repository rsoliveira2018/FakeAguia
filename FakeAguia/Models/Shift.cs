using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FakeAguia.Models
{
    public class Shift
    {
        [DisplayName("Código")]
        public int Id { get; private set; }
        [DisplayName("Turno")]
        public string Name { get; private set; }
        [DisplayName("Início")]
        [DisplayFormat(DataFormatString = "{0:t}")]
        public DateTime BeginsAt { get; private set; }
        [DisplayName("Término")]
        [DisplayFormat(DataFormatString = "{0:t}")]
        public DateTime EndsAt { get; private set; }

        public Shift() { }

        public Shift(int id, string name, DateTime beginsAt, DateTime endsAt)
        {
            Id = id;
            Name = name;
            BeginsAt = beginsAt;
            EndsAt = endsAt;
        }
    }
}
