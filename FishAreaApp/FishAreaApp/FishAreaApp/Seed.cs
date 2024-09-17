using FishAreaApp.Data;
using FishAreaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FishAreaApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.Kho.Any())
            {
                var kho = new Kho
                {
                    Id = Guid.NewGuid(),
                    DanhSachBao = new List<Bao>()
                };
                var baoNep = new BaoNep
                {
                    Id = Guid.NewGuid(),
                    Ten = "Nep Thai",
                    TrongLuong = 50.0f,
                    soLuong = 20,
                    DonGia = 25.0f,
                    NgayNhap = DateTime.Now,
                    NgayHetHan = DateTime.Now.AddDays(45),
                    KhoId = kho.Id
                };
                var baoNep1 = new BaoNep
                {
                    Id = Guid.NewGuid(),
                    Ten = "Nep Bac",
                    TrongLuong = 50.0f,
                    soLuong = 10,
                    DonGia = 22.0f,
                    NgayNhap = DateTime.Now,
                    NgayHetHan = DateTime.Now.AddDays(45),
                    KhoId = kho.Id
                };
                var baoCam = new BaoCam
                {
                    Id = Guid.NewGuid(),
                    Ten = "Cam Ga",
                    TrongLuong = 25.5f,
                    soLuong = 50,
                    DonGia = 15.0f,
                    NgayNhap = DateTime.Now,
                    NgayHetHan = DateTime.Now.AddDays(60),
                    BrandCam = "Rico",
                    KhoId = kho.Id
                };
                var baoGao1 = new BaoGao
                {
                    Id = Guid.NewGuid(),
                    Ten = "Gao ST25 10",
                    soLuong = 10,
                    TrongLuong = 10.0f,
                    DonGia = 26.5f,
                    NgayNhap = DateTime.Now,
                    NgayHetHan = DateTime.Now.AddDays(365*2),
                    KhoId = kho.Id
                };
                var baoGao2 = new BaoGao
                {
                    Id = Guid.NewGuid(),
                    Ten = "Gao Thom Lai",
                    TrongLuong = 10.0f,
                    soLuong = 50,
                    DonGia = 17.5f,
                    NgayNhap = DateTime.Now,
                    NgayHetHan = DateTime.Now.AddDays(365*2),
                    KhoId = kho.Id
                };
                kho.DanhSachBao.Add(baoNep);
                kho.DanhSachBao.Add(baoNep1);
                kho.DanhSachBao.Add(baoCam);
                kho.DanhSachBao.Add(baoGao1);
                kho.DanhSachBao.Add(baoGao2);
                dataContext.Kho.Add(kho);
                dataContext.SaveChanges();
            }
            //else
            //{
            //    var kho = dataContext.Kho.FirstOrDefault();
            //    var baoNep = new BaoNep
            //    {
            //        Id = Guid.NewGuid(),
            //        Ten = "Nep Bao 2",
            //        TrongLuong = 1.0f,
            //        GiaTien = 15.99f,
            //        NgayNhap = DateTime.Now,
            //        NgayHetHan = DateTime.Now.AddDays(45),
            //        KhoId = kho.Id
            //    };
            //    var baoCam = new BaoCam
            //    {
            //        Id = Guid.NewGuid(),
            //        Ten = "Cam Bao 2",
            //        TrongLuong = 0.5f,
            //        GiaTien = 10.99f,
            //        NgayNhap = DateTime.Now,
            //        NgayHetHan = DateTime.Now.AddDays(30),
            //        BrandCam = "Brand 4",
            //        KhoId = kho.Id
            //    };
            //    var baoGao = new BaoGao
            //    {
            //        Id = Guid.NewGuid(),
            //        Ten = "Gao Bao 2",
            //        TrongLuong = 2.0f,
            //        GiaTien = 20.99f,
            //        NgayNhap = DateTime.Now,
            //        NgayHetHan = DateTime.Now.AddDays(60),
            //        KhoId = kho.Id
            //    };
            //    kho.DanhSachBao = new List<Bao>
            //    {
            //        baoGao,
            //        baoCam,
            //        baoNep
            //    };
            //    dataContext.SaveChanges();
            //}

            if (!dataContext.KhachHangs.Any())
            {
                var khachHang = new KhachHang
                {
                    Id = Guid.NewGuid(),
                    Ten = "Customer 1",
                    SoDienThoai = "123456789",
                    DiaChi = "123 Street, City",
                    DanhSachDonHang = new List<DonHang>()
                };
                var baoCam = dataContext.BaoCams.FirstOrDefault();
                var baoNep = dataContext.BaoNeps.FirstOrDefault();
                var baoGao = dataContext.BaoGaos.FirstOrDefault();
                var donHang1 = new DonHang
                {
                    Id = Guid.NewGuid(),
                    NgayMua = DateTime.Now,
                    TongTien = 50,
                    TongTrongLuong = 3,
                    DanhSachCam = baoCam != null ? new List<BaoCam> { baoCam } : null,
                    DanhSachGao = null,
                    DanhSachNep = null,
                    KhachHangId = khachHang.Id
                };                
                var donHang2 = new DonHang
                {
                    Id = Guid.NewGuid(),
                    NgayMua = DateTime.Now,
                    TongTien = 500,
                    TongTrongLuong = 300,
                    DanhSachCam = null,
                    DanhSachGao = baoGao != null ? new List<BaoGao> { baoGao } : null,
                    DanhSachNep = baoNep != null ? new List<BaoNep> { baoNep } : null,
                    KhachHangId = khachHang.Id
                };

                khachHang.DanhSachDonHang.Add(donHang1);
                khachHang.DanhSachDonHang.Add(donHang2);

                dataContext.KhachHangs.Add(khachHang);
                dataContext.SaveChanges();
            }
        }
    }
}
