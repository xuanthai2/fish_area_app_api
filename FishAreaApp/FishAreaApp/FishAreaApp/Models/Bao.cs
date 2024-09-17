namespace FishAreaApp.Models
{
    public class Bao
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public int soLuong { get; set; }
        public float TrongLuong { get; set; }
        public float DonGia { get; set; }
        public DateTime NgayNhap { get; set; }
        public DateTime NgayHetHan { get; set; }
        public Guid KhoId { get; set; }
        public Kho Kho { get; set; }
    }
}
