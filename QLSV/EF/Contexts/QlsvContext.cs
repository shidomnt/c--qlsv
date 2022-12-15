using System;
using System.Collections.Generic;
using System.Configuration;
using QLSV.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace QLSV.EF.Contexts;

public partial class QlsvContext : DbContext
{
    public QlsvContext()
    {
    }

    public QlsvContext(DbContextOptions<QlsvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<KetQua> KetQuas { get; set; }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<MonHoc> MonHocs { get; set; }

    public virtual DbSet<Nganh> Nganhs { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
        optionsBuilder.UseSqlServer(connectionString);
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<KetQua>(entity =>
        {
            entity.HasKey(e => new { e.Mamon, e.Masv }).HasName("PK__KetQua__ED71C127844DD13D");

            entity.ToTable("KetQua");

            entity.Property(e => e.Mamon).HasColumnName("MAMON");
            entity.Property(e => e.Masv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MASV");
            entity.Property(e => e.Diem).HasColumnName("DIEM");

            entity.HasOne(d => d.MamonNavigation).WithMany(p => p.KetQuas)
                .HasForeignKey(d => d.Mamon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KetQua__MAMON__4222D4EF");

            entity.HasOne(d => d.MasvNavigation).WithMany(p => p.KetQuas)
                .HasForeignKey(d => d.Masv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KetQua__MASV__4316F928");
        });

        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.Makhoa).HasName("PK__Khoa__22F41770E09FAFA8");

            entity.ToTable("Khoa");

            entity.Property(e => e.Makhoa).HasColumnName("MAKHOA");
            entity.Property(e => e.Tenkhoa)
                .HasMaxLength(30)
                .HasColumnName("TENKHOA");
        });

        modelBuilder.Entity<MonHoc>(entity =>
        {
            entity.HasKey(e => e.Mamon).HasName("PK__MonHoc__7B73E9850C403AF5");

            entity.ToTable("MonHoc");

            entity.Property(e => e.Mamon).HasColumnName("MAMON");
            entity.Property(e => e.Tenmon)
                .HasMaxLength(30)
                .HasColumnName("TENMON");
        });

        modelBuilder.Entity<Nganh>(entity =>
        {
            entity.HasKey(e => e.Manganh).HasName("PK__Nganh__934F1CE20A24836A");

            entity.ToTable("Nganh");

            entity.Property(e => e.Manganh).HasColumnName("MANGANH");
            entity.Property(e => e.Makhoa).HasColumnName("MAKHOA");
            entity.Property(e => e.Tennganh)
                .HasMaxLength(30)
                .HasColumnName("TENNGANH");

            entity.HasOne(d => d.MakhoaNavigation).WithMany(p => p.Nganhs)
                .HasForeignKey(d => d.Makhoa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Nganh__MAKHOA__398D8EEE");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.Masv).HasName("PK__SinhVien__60228A28A9D66813");

            entity.ToTable("SinhVien");

            entity.Property(e => e.Masv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MASV");
            entity.Property(e => e.Diachi)
                .HasMaxLength(20)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Gioitinh).HasColumnName("GIOITINH");
            entity.Property(e => e.Hosv)
                .HasMaxLength(20)
                .HasColumnName("HOSV");
            entity.Property(e => e.Manganh).HasColumnName("MANGANH");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("date")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Noisinh)
                .HasMaxLength(20)
                .HasColumnName("NOISINH");
            entity.Property(e => e.Tensv)
                .HasMaxLength(20)
                .HasColumnName("TENSV");

            entity.HasOne(d => d.ManganhNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.Manganh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SinhVien__MANGAN__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
