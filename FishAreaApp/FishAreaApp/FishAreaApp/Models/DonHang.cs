namespace FishAreaApp.Models
{
    public class DonHang
    {
        public Guid Id { get; set; }
        public DateTime NgayMua { get; set; }
        public int TongTien { get; set; }
        public int TongTrongLuong { get; set; }
        public ICollection<BaoCam>? DanhSachCam { get; set; }
        public ICollection<BaoGao>? DanhSachGao { get; set; }
        public ICollection<BaoNep>? DanhSachNep { get; set; }
        public Guid KhachHangId { get; set; }
        public KhachHang KhachHang { get; set; }
    }
}
