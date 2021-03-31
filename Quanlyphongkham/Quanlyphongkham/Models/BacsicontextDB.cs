namespace Quanlyphongkham.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BacsicontextDB : DbContext
    {
        public BacsicontextDB()
            : base("name=BacsicontextDB")
        {
        }

        public virtual DbSet<Bacsi> Bacsis { get; set; }
        public virtual DbSet<CV> CVs { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bacsi>()
                .Property(e => e.MBS)
                .IsFixedLength();

            modelBuilder.Entity<CV>()
                .Property(e => e.MBS)
                .IsFixedLength();

            modelBuilder.Entity<Login>()
                .Property(e => e.Tài_khoản)
                .IsFixedLength();

            modelBuilder.Entity<Login>()
                .Property(e => e.Mật_khẩu)
                .IsFixedLength();
        }
    }
}
