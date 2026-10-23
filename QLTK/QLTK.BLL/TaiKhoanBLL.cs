using QLTK.DAL;

namespace QLTK.BLL
{
    public class TaiKhoanBLL
    {
        private readonly TaiKhoanDAL _taiKhoanDAL = new();
        private readonly GiaoDichDAL _giaoDichDAL = new();

        public List<TaiKhoanDto> LayTatCa()
        {
            var taiKhoans = _taiKhoanDAL.LayTatCa();
            var giaoDiches = _giaoDichDAL.LayTatCa();

            return taiKhoans.Select(tk => new TaiKhoanDto
            {
                STK = tk.STK,
                TenNH = tk.TenNH,
                SoDuDauKy = tk.SoDuDauKy,
                SoDuCuoiKy = tk.SoDuDauKy
                    + giaoDiches
                        .Where(gd => gd.STK == tk.STK)
                        .Sum(gd => (decimal)gd.SoTien)
            }).ToList();
        }

        public List<TaiKhoanDto> LaySoDuCuoiKy()
        {
            return LayTatCa();
        }
    }
}