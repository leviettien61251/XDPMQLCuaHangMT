using BUS;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDPMQLCuaHangMT
{
    public class ExcelHandle
    {
        private static ExcelHandle instance;

        public static ExcelHandle Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ExcelHandle();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        public ExcelHandle() { }

        public void SaveExcel(DataGridView dataGridViewName, string titleWb, string titleWs)
        {
            if (dataGridViewName.Rows.Count > 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                var ws = wb.Worksheets.Add(titleWs);

                                var range = ws.Range(1, 1, 1, dataGridViewName.Columns.Count);
                                range.Merge();
                                range.Value = titleWb;
                                range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                range.Style.Font.Bold = true;
                                range.Style.Font.FontSize = 16;

                                // ghi header
                                for (int i = 0; i < dataGridViewName.Columns.Count; i++)
                                {
                                    ws.Cell(2, i + 1).Value = dataGridViewName.Columns[i].HeaderText;
                                }
                                // ghi du lieu
                                for (int i = 0; i < dataGridViewName.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dataGridViewName.Columns.Count; j++)
                                    {
                                        ws.Cell(i + 3, j + 1).Value = dataGridViewName.Rows[i].Cells[j].Value.ToString();
                                    }
                                }
                                ws.Columns().AdjustToContents();
                                wb.SaveAs(sfd.FileName);
                                MessageBox.Show("Xuất phiếu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
