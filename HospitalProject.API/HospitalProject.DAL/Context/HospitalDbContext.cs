using HospitalProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalProject.DAL.Context;

public class HospitalDbContext : DbContext
{
    public DbSet<Insurance> Insurances { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public HospitalDbContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HospitalDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

}
