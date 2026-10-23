using ClosedXML.Excel;
using QLTK.BLL;

namespace QLTK
{
    public class BaoCaoExcel
    {
        public void Xuat(
            string duongDan,
            TaiKhoanDto taiKhoan,
            List<GiaoDichDto> giaoDiches)
        {
            using var workbook = new XLWorkbook();
            var sheet = workbook.Worksheets.Add("SaoKe");

            sheet.Cell("A1").Value = taiKhoan.TenNH;
            sheet.Range("A1:D1").Merge();
            sheet.Cell("A1").Style.Font.Bold = true;
            sheet.Cell("A1").Style.Font.FontSize = 16;

            sheet.Cell("A2").Value = "Số tài khoản: " + taiKhoan.STK;
            sheet.Range("A2:D2").Merge();
            sheet.Cell("A2").Style.Font.Bold = true;

            sheet.Cell("A4").Value = "Id";
            sheet.Cell("B4").Value = "Loại GD";
            sheet.Cell("C4").Value = "Số tiền";
            sheet.Cell("D4").Value = "Nội dung";

            var header = sheet.Range("A4:D4");
            header.Style.Font.Bold = true;
            header.Style.Fill.BackgroundColor =
                XLColor.LightBlue;

            int row = 5;

            foreach (var gd in giaoDiches)
            {
                sheet.Cell(row, 1).Value = gd.Id;
                sheet.Cell(row, 2).Value = gd.LoaiGD;
                sheet.Cell(row, 3).Value = gd.SoTienGoc;
                sheet.Cell(row, 4).Value = gd.NoiDung;
                row++;
            }

            if (row > 5)
            {
                sheet.Range(5, 1, row - 1, 4)
                    .Style.Border.OutsideBorder =
                    XLBorderStyleValues.Thin;

                sheet.Range(5, 1, row - 1, 4)
                    .Style.Border.InsideBorder =
                    XLBorderStyleValues.Thin;
            }

            sheet.Cell(row + 1, 3).Value = "Số dư cuối kỳ";
            sheet.Cell(row + 1, 4).Value =
                taiKhoan.SoDuCuoiKy;
            sheet.Cell(row + 1, 3).Style.Font.Bold = true;
            sheet.Cell(row + 1, 4).Style.Font.Bold = true;

            sheet.Column(3).Style.NumberFormat.Format = "#,##0;[Red]-#,##0";
            sheet.Columns().AdjustToContents();

            workbook.SaveAs(duongDan);
        }
    }
}