using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Accelerate.DataAccessLayer.Models
{
    public partial class AccelerateDBContext : DbContext
    {
        public AccelerateDBContext()
        {
        }

        public AccelerateDBContext(DbContextOptions<AccelerateDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Case> Cases { get; set; }
        public virtual DbSet<ContactDetail> ContactDetails { get; set; }
        public virtual DbSet<DashBoard> DashBoards { get; set; }
        public virtual DbSet<ReportDatum> ReportData { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("AccelerateDBConnectionString");

            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog=AccelerateDB;Integrated Security=true");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Case>(entity =>
            {
                entity.ToTable("Case");

                entity.Property(e => e.CaseId).ValueGeneratedNever();

                entity.Property(e => e.CaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Challenge)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Solution)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Client)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryAnchor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryManager).HasColumnType("numeric(7, 0)");

                entity.Property(e => e.DeliveryManagerId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OfferingHead)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Case)
                    .WithMany()
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK__ContactDe__CaseI__286302EC");
            });

            modelBuilder.Entity<DashBoard>(entity =>
            {
                entity.HasKey(e => e.CaseId)
                    .HasName("PK__DashBoar__6CAE524CFE99ABF3");

                entity.ToTable("DashBoard");

                entity.Property(e => e.CaseId).ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Horizontal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SearchWords)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SensitivityLevel)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Vertical)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Case)
                    .WithOne(p => p.DashBoard)
                    .HasForeignKey<DashBoard>(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DashBoard__CaseI__2B3F6F97");
            });

            modelBuilder.Entity<ReportDatum>(entity =>
            {
                entity.HasKey(e => e.CaseId)
                    .HasName("PK__ReportDa__6CAE524CC0E5834C");

                entity.Property(e => e.CaseId).ValueGeneratedNever();

                entity.Property(e => e.Decrease1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Decrease11).HasColumnName("Decrease1%");

                entity.Property(e => e.Decrease2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Decrease21).HasColumnName("Decrease2%");

                entity.Property(e => e.Increase1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Increase11).HasColumnName("Increase1%");

                entity.Property(e => e.Increase2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Increase21).HasColumnName("Increase2%");

                entity.HasOne(d => d.Case)
                    .WithOne(p => p.ReportDatum)
                    .HasForeignKey<ReportDatum>(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReportDat__CaseI__2E1BDC42");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
