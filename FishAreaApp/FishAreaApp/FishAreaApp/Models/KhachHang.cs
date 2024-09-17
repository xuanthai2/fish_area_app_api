namespace FishAreaApp.Models
{
    public class KhachHang
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public ICollection<DonHang> DanhSachDonHang { get; set; }
    }
}
