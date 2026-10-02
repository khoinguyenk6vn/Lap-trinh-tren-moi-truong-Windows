using System;
using System.Collections.Generic;
using System.Text;
namespace Lab04
{
    public class NhanVien
    {
        public string MSNV { get; set; } = "";
        public string TenNV { get; set; } = "";
        public decimal LuongCB { get; set; }

        public NhanVien()
        {
        }

        public NhanVien(string msnv, string tenNV, decimal luongCB)
        {
            MSNV = msnv;
            TenNV = tenNV;
            LuongCB = luongCB;
        }
    }
}