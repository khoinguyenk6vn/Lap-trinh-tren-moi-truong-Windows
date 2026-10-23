using QLTK.DAL;
using QLTK.DAL.Models;

namespace QLTK.BLL
{
    public class GiaoDichBLL
    {
        private readonly GiaoDichDAL _giaoDichDAL = new();
        private readonly TaiKhoanDAL _taiKhoanDAL = new();

        public List<GiaoDichDto> LayTatCa()
        {
            return ChuyenDoi(_giaoDichDAL.LayTatCa());
        }

        public List<GiaoDichDto> LayGiaoDichNhanTien()
        {
            return ChuyenDoi(_giaoDichDAL.LayGiaoDichNhanTien());
        }

        public List<GiaoDichDto> LayTheoTaiKhoan(string stk)
        {
            return ChuyenDoi(_giaoDichDAL.LayTheoTaiKhoan(stk));
        }

        public void Them(
            string stk,
            string loaiGD,
            int soTien,
            string? noiDung)
        {
            if (soTien < 1 || soTien > 100_000_000)
            {
                throw new InvalidOperationException(
                    "Vui lòng nhập số tiền từ 1-100000000!");
            }

            var taiKhoan = _taiKhoanDAL.LayTatCa()
                .FirstOrDefault(tk => tk.STK == stk);

            if (taiKhoan == null)
            {
                throw new InvalidOperationException(
                    "Không tìm thấy tài khoản!");
            }

            bool rutTien = loaiGD == "Rút tiền";

            if (!rutTien && loaiGD != "Nhận tiền")
            {
                throw new InvalidOperationException(
                    "Vui lòng chọn loại giao dịch!");
            }

            if (rutTien)
            {
                decimal soDuCuoiKy = taiKhoan.SoDuDauKy
                    + _giaoDichDAL.LayTheoTaiKhoan(stk)
                        .Sum(gd => (decimal)gd.SoTien);

                if (soTien > soDuCuoiKy)
                {
                    throw new InvalidOperationException(
                        "Tài khoản không đủ số tiền để rút!");
                }
            }

            var giaoDich = new GiaoDich
            {
                STK = stk,
                SoTien = rutTien ? -soTien : soTien,
                NoiDung = string.IsNullOrWhiteSpace(noiDung)
                    ? null
                    : noiDung.Trim()
            };

            _giaoDichDAL.Them(giaoDich);
        }

        private static List<GiaoDichDto> ChuyenDoi(
            IEnumerable<GiaoDich> danhSach)
        {
            return danhSach.Select(gd => new GiaoDichDto
            {
                Id = gd.Id,
                STK = gd.STK,
                LoaiGD = gd.SoTien > 0
                    ? "Nhận tiền"
                    : "Rút tiền",
                SoTien = Math.Abs(gd.SoTien),
                SoTienGoc = gd.SoTien,
                NoiDung = gd.NoiDung ?? ""
            }).ToList();
        }
    }
}