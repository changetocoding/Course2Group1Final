using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace BankApp.Data.Scaffolded
{
    public partial class BankContext : DbContext
    {
        public BankContext()
        {
        }

        public BankContext(DbContextOptions<BankContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountDb> AccountDbs { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=(LocalDB)\\MSSQLLocalDB;initial catalog=Bank;MultipleActiveResultSets=True;App=EntityFramework");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountDb>(entity =>
            {
                entity.ToTable("AccountDb");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.PaidIn).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Withdrawn).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("Notification");

                entity.Property(e => e.Email).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
