namespace FishAreaApp.Models
{
    public class Kho
    {
        public Guid Id { get; set; }
        public ICollection<Bao> DanhSachBao { get; set; }
    }
}
