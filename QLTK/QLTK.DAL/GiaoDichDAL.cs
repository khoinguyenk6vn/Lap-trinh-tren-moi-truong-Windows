using Microsoft.EntityFrameworkCore;
using QLTK.DAL.Models;

namespace QLTK.DAL
{
    public class GiaoDichDAL
    {
        public List<GiaoDich> LayTatCa()
        {
            using var db = new QLTKContext();

            return db.GiaoDiches
                .AsNoTracking()
                .OrderByDescending(gd => gd.Id)
                .ToList();
        }

        public List<GiaoDich> LayGiaoDichNhanTien()
        {
            using var db = new QLTKContext();

            return db.GiaoDiches
                .AsNoTracking()
                .Where(gd => gd.SoTien > 0)
                .OrderByDescending(gd => gd.Id)
                .ToList();
        }

        public List<GiaoDich> LayTheoTaiKhoan(string stk)
        {
            using var db = new QLTKContext();

            return db.GiaoDiches
                .AsNoTracking()
                .Where(gd => gd.STK == stk)
                .OrderBy(gd => gd.Id)
                .ToList();
        }

        public void Them(GiaoDich giaoDich)
        {
            using var db = new QLTKContext();

            db.GiaoDiches.Add(giaoDich);
            db.SaveChanges();
        }
    }
}