using FishAreaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FishAreaApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
        
        }
        public DbSet<Bao> Baos { get; set; }
        public DbSet<BaoCam> BaoCams { get; set; }
        public DbSet<BaoGao> BaoGaos { get; set; }
        public DbSet<BaoNep> BaoNeps { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<Kho> Kho { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonHang>()
                .HasOne(dh => dh.KhachHang)
                .WithMany(kh => kh.DanhSachDonHang)
                .HasForeignKey(dh => dh.KhachHangId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Bao>()
                .HasOne(b => b.Kho)
                .WithMany(k => k.DanhSachBao)
                .HasForeignKey(b => b.KhoId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Bao>()
                .HasDiscriminator<string>("BaoType")
                .HasValue<BaoCam>("Cam")
                .HasValue<BaoGao>("Gao")
                .HasValue<BaoNep>("Nep");       
        }
    }
}
