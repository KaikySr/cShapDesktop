using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DesafioERP.Model;

public partial class DesafioerpaContext : DbContext
{
    public DesafioerpaContext()
    {
    }

    public DesafioerpaContext(DbContextOptions<DesafioerpaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Git> Gits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=CT-C-0018G\\SQLEXPRESS;Initial Catalog=desafioerpa;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Git>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__git__3214EC2707D70A1D");

            entity.ToTable("git");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdate");
            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
