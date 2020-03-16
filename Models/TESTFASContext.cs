using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace fas_dashboard_api.Models
{
    public partial class TESTFASContext : DbContext
    {
        public TESTFASContext()
        {
        }

        public TESTFASContext(DbContextOptions<TESTFASContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Funds> Funds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>(entity =>
            {
                entity.HasKey(e => e.ClientId)
                    .HasName("pk_Clients_ClientID");

                entity.ToTable("Clients", "Masters");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Funds>(entity =>
            {
                entity.HasKey(e => e.FundId)
                    .HasName("pk_Funds_FundID");

                entity.ToTable("Funds", "Masters");

                entity.Property(e => e.FundId)
                    .HasColumnName("FundID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.FundName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalFundId).HasColumnName("GlobalFundID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Funds)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Funds_ClientID");
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
