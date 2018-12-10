﻿using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
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
        public static void SaveDataGridViewExportToExcel(DataGridView dgv)
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

                    MessageHandler.ShowMessageBox("导出成功");
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
        public static void SaveDevGridControlExportToExcel(GridView GV)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel files (*.xls)|*.xls";
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;
            dlg.Title = "保存为Excel文件";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                //GV.ExportToExcelOld(Filename);
                GV.ExportToXls(fileName);

                MessageHandler.ShowMessageBox("导出成功");
            }
        }

        /// <summary>
        /// 把DataTable内容保存到Excel中
        /// </summary>
        /// <param name="tmpDataTable">数据表</param>
        public static void SaveDataTableExportToExcel(DataTable tmpDataTable)
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
                    for (int i = 0; i < tmpDataTable.Columns.Count; i++)
                    {
                            columnTitle += tmpDataTable.Columns[i].Caption;
                            columnTitle += "\t";                        
                    }
                    columnTitle = columnTitle.Substring(0, columnTitle.Length - 1);

                    sw.WriteLine(columnTitle);

                    //写入内容
                    for (int j = 0; j < tmpDataTable.Rows.Count; j++)
                    {
                        string columnValue = "";
                        for (int k = 0; k < tmpDataTable.Columns.Count; k++)
                        {
                                if (tmpDataTable.Rows[j][k] == null)
                                {
                                    columnValue += "";
                                }
                                else
                                {
                                    columnValue += tmpDataTable.Rows[j][k].ToString().Trim();
                                }
                                columnValue += "\t";                            
                        }
                        columnValue = columnValue.Substring(0, columnValue.Length - 1);
                        sw.WriteLine(columnValue);
                    }

                    MessageHandler.ShowMessageBox("导出成功");
                }
                finally
                {
                    sw.Close();
                    myStream.Close();
                }
            }
        }

        /// <summary>
        /// 将DataGridView中的数据导出到CSV格式文件
        /// </summary>
        /// <param name="dgv">DataGridView对象名称</param>
        /// <param name="fileName">导出文件的默认文件名</param>
        public static void DataGridViewExportToCSV(DataGridView dgv, string fileName)
        {
            if (dgv.Rows.Count < 1)
            {
                MessageBox.Show("没有记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Filter = "CSV文件(*.csv)|*.csv|文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            sfDialog.FilterIndex = 0;
            sfDialog.FileName = fileName;
            if (sfDialog.ShowDialog() == DialogResult.OK)
            {

                string strFileName = sfDialog.FileName;
                StreamWriter sw = new StreamWriter(strFileName, false, Encoding.Unicode);
                string strLine = "";
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (col.Visible)
                    {
                        //为禁止转义在前边多加上一个TAB符号(\t)
                        strLine += "\"\t" + col.HeaderText.Trim().Replace("\"", "\\\"") + "\"" + "\t";
                    }
                }
                strLine = strLine.Substring(0, strLine.Length - 1);
                sw.WriteLine(strLine);
                sw.Flush();

                foreach (DataGridViewRow dgvr in dgv.Rows)
                {
                    strLine = "";
                    foreach (DataGridViewCell dgvc in dgvr.Cells)
                    {
                        if (dgvc.Visible)
                        {
                            if (dgvc.Value == null)
                            {
                                strLine += "\t";
                            }
                            else
                            {
                                //为禁止转义在前边多加上一个TAB符号(\t)
                                strLine += "\"\t" + dgvc.Value.ToString().Trim().Replace("\"", "\"\"") + "\"" + "\t";
                            }
                        }
                    }
                    sw.WriteLine(strLine);
                    sw.Flush();
                }
                sw.Close();
                MessageHandler.ShowMessageBox(string.Format("导出成功!数据已成功导出至\n{0}\n文件中!", strFileName));
            }
        }
    }
}