using System;
using FakeAguia.Models;
using Microsoft.EntityFrameworkCore;

namespace FakeAguia.Data
{
    public class FakeAguiaContext : DbContext
    {
        public FakeAguiaContext(DbContextOptions<FakeAguiaContext> options) : base(options) { }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Plant> Plant { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Shift> Shift { get; set; }
    }
}
