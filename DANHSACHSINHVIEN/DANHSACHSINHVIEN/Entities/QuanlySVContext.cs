using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DANHSACHSINHVIEN.Entities
{
    public partial class QuanlySVContext : DbContext
    {
        public QuanlySVContext()
            : base("name=QuanlySVContext")
        {
        }

        public virtual DbSet<Lop> Lop { get; set; }
        public virtual DbSet<Sinhvien> Sinhvien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lop>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sinhvien>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sinhvien>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
