using HospitalProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalProject.DAL.Configurations;

public class InsuranceConfiguraton : IEntityTypeConfiguration<Insurance>
{
    public void Configure(EntityTypeBuilder<Insurance> builder)
    {
        builder.Property(i => i.PersonInsurance)
                .IsRequired()
                .HasMaxLength(100); 

        builder.Property(i => i.Discount)
            .IsRequired();

        builder.HasMany(i => i.Patients)
          .WithOne(p => p.Insurance)
          .HasForeignKey(p => p.InsuranceId);
    }
}
