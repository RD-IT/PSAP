using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAP.PSAPCommon
{
    class FileHandler
    {
        /// <summary>
        /// 把DataGridView内容保存到Excel中
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>
        public static void SaveDataGridViewToCVS(DataGridView dgv)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel files (*.xls)|*.xls";
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;
            //dlg.CreatePrompt = true;
            dlg.Title = "保存为Excel文件";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Stream myStream;
                myStream = dlg.OpenFile();
                StreamWriter sw = new StreamWriter(myStream, Encoding.GetEncoding("gb2312"));
                string columnTitle = "";
                try
                {
                    //写入列标题
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        if (dgv.Columns[i].Visible)
                        {
                            columnTitle += dgv.Columns[i].HeaderText;
                            columnTitle += "\t";
                        }
                    }
                    columnTitle = columnTitle.Substring(0, columnTitle.Length - 1);

                    sw.WriteLine(columnTitle);

                    //写入内容
                    for (int j = 0; j < dgv.Rows.Count; j++)
                    {
                        string columnValue = "";
                        for (int k = 0; k < dgv.Columns.Count; k++)
                        {
                            if (dgv.Columns[k].Visible)
                            {
                                if (dgv.Rows[j].Cells[k].Value == null)
                                {
                                    columnValue += "";
                                }
                                else
                                {
                                    columnValue += dgv.Rows[j].Cells[k].Value.ToString().Trim();
                                }
                                columnValue += "\t";
                            }
                        }
                        columnValue = columnValue.Substring(0, columnValue.Length - 1);
                        sw.WriteLine(columnValue);
                    }
                }
                finally
                {
                    sw.Close();
                    myStream.Close();
                }
            }
        }

        /// <summary>
        /// 把DevGridControl内容保存到Excel中
        /// </summary>
        /// <param name="GV">GridView控件</param>
        public static void SaveDevGridControlToCVS(GridView GV)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel files (*.xls)|*.xls";
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;
            dlg.Title = "保存为Excel文件";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string Filename = dlg.FileName;
                //GV.ExportToExcelOld(Filename);
                GV.ExportToXls(Filename);
            }
        }

    }
}
