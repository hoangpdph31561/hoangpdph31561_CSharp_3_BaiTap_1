using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using hoangpdph31561_CSharp_3_BaiTap_1.DomainClass;

namespace hoangpdph31561_CSharp_3_BaiTap_1.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LoaiXe> LoaiXes { get; set; }

    public virtual DbSet<XeMay> XeMays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=PHAMDUCHOANG\\SQLEXPRESS;Initial Catalog=QUANLYXEMAY_CS3_XUONG;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LoaiXe>(entity =>
        {
            entity.HasKey(e => e.IdLoaiXe).HasName("pk_LoaiXe");

            entity.Property(e => e.IdLoaiXe).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<XeMay>(entity =>
        {
            entity.HasKey(e => e.IdXeMay).HasName("pk_XeMay");

            entity.Property(e => e.IdXeMay).ValueGeneratedNever();

            entity.HasOne(d => d.IdLoaiXeNavigation).WithMany(p => p.XeMays).HasConstraintName("fk_XeMay_LoaiXe");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
