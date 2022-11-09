using CryptoHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Psychology.Core.Enums;
using Psychology.Core.Models;
using System;

namespace Psychology.Data.Configurations
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder
                .HasKey(a => a.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
               .Property(m => m.Status)
               .IsRequired()
               .HasDefaultValue(true);

            builder
               .Property(m => m.AdminStatus)
               .IsRequired()
               .HasDefaultValue((byte)AdminStatusEnum.OnHold);

            builder
                .Property(m => m.Fullname)
                .HasMaxLength(50);

            builder
                .Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(m => m.Password)
                .HasMaxLength(100);

            builder
               .Property(m => m.Token)
               .HasMaxLength(100);

            builder
               .Property(m => m.ProfilePhoto)
               .HasMaxLength(100);

            builder
               .Property(m => m.InvitedToken)
               .HasMaxLength(100);

            builder
               .Property(m => m.ModifiedBy)
               .HasMaxLength(100);

            builder
               .Property(m => m.CreatedBy)
               .HasMaxLength(100);

            builder
               .Property(m => m.CreatedDate)
               .HasDefaultValue(DateTime.Now);

            builder
              .Property(m => m.ModifiedDate)
              .HasDefaultValue(DateTime.Now);

            builder
            .HasData(
                new Admin
                {
                    Id = 1,
                    AdminStatus = (byte)AdminStatusEnum.Active,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    Email = "admin@gmail.com",
                    Fullname = "Admin",
                    ModifiedDate = DateTime.MinValue,
                    Password = Crypto.HashPassword("admin123"),
                    Token = Guid.NewGuid().ToString()
                }
            );

            builder
                .ToTable("Admins");
        }
    }
}
