using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Khuselo_BatteryCheck_r1.Models
{
    public partial class Khuselo_3Context : DbContext
    {
        public Khuselo_3Context()
        {
        }

        public Khuselo_3Context(DbContextOptions<Khuselo_3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<KhuseloDb3> KhuseloDb3s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhuseloDb3>(entity =>
            {
                entity.ToTable("KhuseloDb3");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Branch).IsUnicode(false);

                entity.Property(e => e.Brand).IsUnicode(false);

                entity.Property(e => e.ChargeCycles)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateExpired).HasColumnType("date");

                entity.Property(e => e.DateInstalled)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DatePurchased).HasColumnType("date");

                entity.Property(e => e.Lifespan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TechName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
