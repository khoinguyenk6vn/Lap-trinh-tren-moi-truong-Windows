using Microsoft.EntityFrameworkCore;
using QLTK.DAL.Models;

namespace QLTK.DAL
{
    public class TaiKhoanDAL
    {
        public List<TaiKhoan> LayTatCa()
        {
            using var db = new QLTKContext();

            return db.TaiKhoans
                .AsNoTracking()
                .OrderBy(tk => tk.STK)
                .ToList();
        }
    }
}