using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _2310900094_KimNgocTam.Models;

public partial class KimNgocTam2310900094Context : DbContext
{
    public KimNgocTam2310900094Context()
    {
    }

    public KimNgocTam2310900094Context(DbContextOptions<KimNgocTam2310900094Context> options)
        : base(options)
    {
    }

    public virtual DbSet<KntEmployee> KntEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=KimNgocTam_2310900094;TrustServerCertificate=True;Trusted_Connection=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<KntEmployee>(entity =>
        {
            entity.HasKey(e => e.KntEmpId).HasName("PK__kntEmplo__28A2D7353DD489F7");

            entity.ToTable("kntEmployee");

            entity.Property(e => e.KntEmpId)
                .ValueGeneratedNever()
                .HasColumnName("kntEmpId");
            entity.Property(e => e.KntEmpLevel)
                .HasMaxLength(150)
                .HasColumnName("kntEmpLevel");
            entity.Property(e => e.KntEmpName)
                .HasMaxLength(255)
                .HasColumnName("kntEmpName");
            entity.Property(e => e.KntEmpStartDate).HasColumnName("kntEmpStartDate");
            entity.Property(e => e.KntEmpStatus).HasColumnName("kntEmpStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
