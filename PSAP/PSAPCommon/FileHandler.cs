using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PSAP.PSAPCommon
{
    class FileHandler
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public PSAP.VIEW.BSVIEW.FrmLanguageText f = null;
        public FileHandler()
        {
            f = new PSAP.VIEW.BSVIEW.FrmLanguageText();
            PSAP.BLL.BSBLL.BSBLL.language(f);//刷新窗口语言
        }

        /// <summary>
        /// 把DataGridView内容保存到Excel中
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>
        public void SaveDataGridViewExportToExcel(DataGridView dgv)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel files (*.xls)|*.xls";
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;
            //dlg.CreatePrompt = true;
            //dlg.Title = "保存为Excel文件";
            dlg.Title = f.tsmiBcwexc.Text;


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

                    //MessageHandler.ShowMessageBox("导出成功");
                    MessageHandler.ShowMessageBox(f.tsmiDccg.Text);

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
            dlg.Filter = "Excel files (*.xlsx)|*.xlsx";
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;
            //dlg.Title = "保存为Excel文件";
            dlg.Title = new FileHandler().f.tsmiBcwexc.Text;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                //GV.ExportToExcelOld(Filename);
                GV.ExportToXlsx(fileName);

                //MessageHandler.ShowMessageBox("导出成功");
                MessageHandler.ShowMessageBox(new FileHandler().f.tsmiDccg.Text);

            }
        }

        /// <summary>
        /// 把TreeList内容保存到Excel中
        /// </summary>
        /// <param name="TL">TreeList控件</param>
        public static void SaveTreeListControlExportToExcel(DevExpress.XtraTreeList.TreeList TL)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel files (*.xlsx)|*.xlsx";
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;
            //dlg.Title = "保存为Excel文件";
            dlg.Title = new FileHandler().f.tsmiBcwexc.Text;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                //GV.ExportToExcelOld(Filename);
                TL.ExportToXlsx(fileName);

                //MessageHandler.ShowMessageBox("导出成功");
                MessageHandler.ShowMessageBox(new FileHandler().f.tsmiDccg.Text);

            }
        }

        /// <summary>
        /// 把DataTable内容保存到Excel中
        /// </summary>
        /// <param name="tmpDataTable">数据表</param>
        public void SaveDataTableExportToExcel(DataTable tmpDataTable)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel files (*.xlsx)|*.xlsx";
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;
            //dlg.CreatePrompt = true;
            //dlg.Title = "保存为Excel文件";
            dlg.Title = f.tsmiBcwexc.Text;


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

                    //MessageHandler.ShowMessageBox("导出成功");
                    MessageHandler.ShowMessageBox(f.tsmiDccg.Text);

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
                //MessageHandler.ShowMessageBox("没有记录！");
                MessageHandler.ShowMessageBox(new FileHandler().f.tsmiMyjl.Text);
                return;
            }

            SaveFileDialog sfDialog = new SaveFileDialog();
            //sfDialog.Filter = "CSV文件(*.csv)|*.csv|文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            sfDialog.Filter = new FileHandler().f.tsmiCsvwj.Text;
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
                //MessageHandler.ShowMessageBox(string.Format("导出成功!数据已成功导出至\n{0}\n文件中!", strFileName));
                MessageHandler.ShowMessageBox(string.Format(new FileHandler().f.tsmiDccgsj.Text + "\n{0}\n" + new FileHandler().f.tsmiWjz.Text, strFileName));

            }
        }

        /// <summary>
        /// 将图片文件转换为Byte数组
        /// </summary>
        /// <param name="filePathStr">图片文件路径</param>
        public byte[] ImageFileToByteArray(string filePathStr)
        {
            if (File.Exists(filePathStr))
            {
                Image img = new Bitmap(filePathStr);
                MemoryStream stream = new MemoryStream();
                img.Save(stream, ImageFormat.Bmp);
                BinaryReader br = new BinaryReader(stream);
                byte[] bytes = stream.ToArray();
                stream.Close();
                return bytes;
            }
            else
                return null;
        }

        /// <summary>
        /// 将Byte数组转换为Image类型变量
        /// </summary>
        /// <param name="bytes">数据流</param>
        public Image StreamToImage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            ms.Position = 0;
            Image img = Image.FromStream(ms);
            ms.Close();
            return img;
        }

        /// <summary>
        /// 将数据流转换为文件
        /// </summary>
        /// <param name="bytes">数据流</param>
        /// <param name="saveFilePath">保存图片文件路径</param>
        public int StreamToFile(byte[] bytes, string saveFilePath)
        {
            FileStream fs = new FileStream(saveFilePath, FileMode.Create, FileAccess.Write);
            fs.Write(bytes, 0, bytes.Length);
            fs.Flush();
            fs.Close();
            return 0;
        }

        /// <summary>
        /// 将文件转换为Byte数组
        /// </summary>
        public Byte[] FileToByteArray(string filePathStr, ref long streamLength)
        {
            if (File.Exists(filePathStr))
            {
                FileStream fStream = new FileInfo(filePathStr).OpenRead();
                Byte[] bytes = new Byte[fStream.Length];
                fStream.Read(bytes, 0, Convert.ToInt32(fStream.Length));
                streamLength = fStream.Length;
                fStream.Close();
                return bytes;
            }
            else
                return null;
        }

        /// <summary>
        /// 将Byte数组保存为指定路径文件
        /// </summary>
        public void ByteArrayToFile(Byte[] bytes, string filePathStr)
        {
            MemoryStream mStream = new MemoryStream(bytes);
            string file = string.Format(filePathStr,
            Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase));
            FileStream fStream = new FileStream(file, FileMode.Create);
            mStream.WriteTo(fStream);
            mStream.Close();
            fStream.Close();
        }

        /// <summary> 
        /// 写入INI文件 
        /// </summary> 
        /// <param name="section">项目名称(如 [TypeName] )</param> 
        /// <param name="key">键</param> 
        /// <param name="value">值</param> 
        public void IniWriteValue(string iniPath, string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, iniPath);
        }

        /// <summary> 
        /// 读出INI文件 
        /// </summary> 
        /// <param name="section">项目名称(如 [TypeName] )</param> 
        /// <param name="key">键</param> 
        public string IniReadValue(string iniPath, string section, string key)
        {
            StringBuilder temp = new StringBuilder(500);
            int i = GetPrivateProfileString(section, key, "", temp, 500, iniPath);
            return temp.ToString();
        }

        /// <summary>
        /// 按照指定路径读取Excel的第一个Sheet里面的数据到表中
        /// </summary>
        public void ExcelToDataTable(DataTable queryDataTable, string fullPathStr)
        {
            if (File.Exists(fullPathStr))
            {
                string connStr = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'", fullPathStr);
                if (fullPathStr.Substring(fullPathStr.Length - 4).ToLower() == ".xls")
                    connStr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0; HDR=YES; IMEX=1;'", fullPathStr);
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string tableNameStr = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null).Rows[0][2].ToString().Trim();
                    string sqlStr = string.Format("select * from [{0}]", tableNameStr);
                    OleDbDataAdapter adapt = new OleDbDataAdapter(sqlStr, conn);
                    adapt.Fill(queryDataTable);
                    conn.Close();
                }
            }
        }
    }
}
