using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models;

public partial class DietDbContext : DbContext
{
    public DietDbContext()
    {
    }

    public DietDbContext(DbContextOptions<DietDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Meal> Meals { get; set; }

    public virtual DbSet<Nutrition> Nutritions { get; set; }

    public virtual DbSet<NutritionValue> NutritionValues { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserNutrition> UserNutritions { get; set; }

    public virtual DbSet<UsersDetail> UsersDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=LAPTOP-DCAA7GQH\\MSSQLSERVERHIVDA;database=DietDB;trusted_connection=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.CategoryName).HasMaxLength(100);
        });

        modelBuilder.Entity<Meal>(entity =>
        {
            entity.Property(e => e.MealName).HasMaxLength(80);
        });

        modelBuilder.Entity<Nutrition>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Nutritions_CategoryId");

            entity.HasIndex(e => e.NutritionValueId, "IX_Nutritions_NutritionValueId");

            entity.Property(e => e.NutritionName).HasMaxLength(110);

            entity.HasOne(d => d.Category).WithMany(p => p.Nutritions).HasForeignKey(d => d.CategoryId);

            entity.HasOne(d => d.NutritionValue).WithMany(p => p.Nutritions).HasForeignKey(d => d.NutritionValueId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.UserDetailId, "IX_Users_UserDetailId").IsUnique();

            entity.Property(e => e.Answer).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.SecurityQuestion).HasMaxLength(150);
            entity.Property(e => e.Surname).HasMaxLength(100);

            entity.HasOne(d => d.UserDetail).WithOne(p => p.User).HasForeignKey<User>(d => d.UserDetailId);
        });

        modelBuilder.Entity<UserNutrition>(entity =>
        {
            entity.HasIndex(e => e.MealId, "IX_UserNutritions_MealId");

            entity.HasIndex(e => e.NutritionId, "IX_UserNutritions_NutritionId");

            entity.HasIndex(e => e.UserId, "IX_UserNutritions_UserId");

            entity.HasOne(d => d.Meal).WithMany(p => p.UserNutritions).HasForeignKey(d => d.MealId);

            entity.HasOne(d => d.Nutrition).WithMany(p => p.UserNutritions).HasForeignKey(d => d.NutritionId);

            entity.HasOne(d => d.User).WithMany(p => p.UserNutritions).HasForeignKey(d => d.UserId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
