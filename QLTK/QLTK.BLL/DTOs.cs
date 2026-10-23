namespace QLTK.BLL
{
    public class TaiKhoanDto
    {
        public string STK { get; set; } = "";
        public string TenNH { get; set; } = "";
        public decimal SoDuDauKy { get; set; }
        public decimal SoDuCuoiKy { get; set; }
    }

    public class GiaoDichDto
    {
        public int Id { get; set; }
        public string STK { get; set; } = "";
        public string LoaiGD { get; set; } = "";
        public int SoTien { get; set; }
        public int SoTienGoc { get; set; }
        public string NoiDung { get; set; } = "";
    }
}