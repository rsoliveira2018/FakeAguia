using FakeAguia.Models;
using System.Linq;
using System;

namespace FakeAguia.Data
{
    public class SeedingService
    {
        private FakeAguiaContext _context;

        public SeedingService() { }

        public SeedingService(FakeAguiaContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Employee.Any() ||
                _context.Role.Any() ||
                _context.Plant.Any() ||
                _context.Region.Any() ||
                _context.Shift.Any())
            {
                // Database has already been seeded
                return;
            }

            // Creating the date to be inputted to the database
            Region r1 = new Region(1, "Piracicaba");
            Region r2 = new Region(2, "Andradina");
            Region r3 = new Region(3, "Aracatuba");

            Role o1 = new Role(1, "GO");
            Role o2 = new Role(2, "Supervisor");
            Role o3 = new Role(3, "Administrador");
            Role o4 = new Role(4, "GP");

            Plant p1 = new Plant(1, "COPI", r1);
            Plant p2 = new Plant(2, "GASA", r2);
            Plant p3 = new Plant(3, "IPAU", r3);
            Plant p4 = new Plant(4, "MUND", r2);
            Plant p5 = new Plant(5, "USH", r1);

            Shift s1 = new Shift(1, "A", new DateTime(2020, 01, 01, 23, 00, 00), new DateTime(2020, 01, 01, 07, 00, 00));
            Shift s2 = new Shift(2, "B", new DateTime(2020, 01, 01, 07, 00, 00), new DateTime(2020, 01, 01, 15, 00, 00));
            Shift s3 = new Shift(3, "C", new DateTime(2020, 01, 01, 15, 00, 00), new DateTime(2020, 01, 01, 23, 00, 00));


            Employee e1 = new Employee(1, "Rafael Oliveira", p1, o3, Profile.Admin, s1);
            Employee e2 = new Employee(2, "Erika Duarte", p1, o3, Profile.Admin, s2);
            Employee e3 = new Employee(3, "João Abreu", p1, o3, Profile.Admin, s3);
            Employee e4 = new Employee(4, "Beatriz Debiasi", p2, o2, Profile.Portal, s1);
            Employee e5 = new Employee(5, "Kauê Zatarin", p2, o2, Profile.Portal, s2);
            Employee e6 = new Employee(6, "Vinícius Moreira", p2, o2, Profile.App, s3);
            Employee e7 = new Employee(7, "Jaqueline Kozakievu", p3, o1, Profile.App, s1);
            Employee e8 = new Employee(8, "Ricardo Araújo", p3, o1, Profile.App, s2);
            Employee e9 = new Employee(9, "Luciano Teixeira", p3, o1, Profile.App, s3);
            Employee e10 = new Employee(10, "Mondini Pai", p4, o4, Profile.App, s1);
            Employee e11 = new Employee(11, "Mondini Filho", p4, o4, Profile.App, s2);
            Employee e12 = new Employee(12, "Jota Júnior", p4, o4, Profile.App, s3);
            Employee e13 = new Employee(13, "Sikêra Junior", p5, o1, Profile.App, s1);
            Employee e14 = new Employee(14, "Geraldo Brasil", p5, o1, Profile.App, s2);
            Employee e15 = new Employee(15, "Gustavo Jardim", p5, o1, Profile.App, s3);

            _context.Employee.AddRange(e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15);
            _context.Shift.AddRange(s1, s2, s3);
            _context.Plant.AddRange(p1, p2, p3, p4, p5);
            _context.Role.AddRange(o1, o2, o3, o4);
            _context.Region.AddRange(r1, r2, r3);

            _context.SaveChanges();
        }
    }
}