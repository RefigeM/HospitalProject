using HospitalProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalProject.DAL.Configurations;

public class PatientConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.Property(p => p.Name)
           .IsRequired()
           .HasMaxLength(100);

        builder.Property(p => p.Surname)
            .IsRequired()
            .HasMaxLength(100); 

        builder.Property(p => p.DOB)
            .IsRequired(); 

        builder.Property(p => p.Gender)
            .IsRequired(); 

        builder.Property(p => p.BloodGroup)
            .IsRequired(); 

        builder.Property(p => p.PhoneNumber)
            .IsRequired()
            .HasMaxLength(15); 

        builder.Property(p => p.SeriaNumber)
            .IsRequired()
            .HasMaxLength(50); 

        builder.Property(p => p.RegistrationAddress)
            .IsRequired()
            .HasMaxLength(250);

        builder.Property(p => p.CurrentAddress)
            .IsRequired()
            .HasMaxLength(250);

        builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(150);

        builder.HasOne(p => p.Insurance)
            .WithMany(i => i.Patients)
            .HasForeignKey(p => p.InsuranceId);
            
    }
}
