using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace PSAP.PSAPCommon
{
    public abstract class psapCommon
    {
       
         //* *************************
         //* 全局变量定义*************
         //*************************** 
       // public static DataRow LoginInfo;//存放当前登陆用户信息


        //* *************************
        //* 公共方法定义*************
        //*************************** 
        public void paspCommon()
        {
        }

        /// <summary>
        /// 回车时将焦点定位到下一个控件
        /// </summary>
        /// <param name="e"></param>
        public static void EnterDoTab(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");  //回车时将焦点定位到下一个控件
            }
        }

        public static Label LblInfo = new Label();//信息标签
        /// <summary>
        /// 判断目标文本框是否为空
        /// </summary>
        /// <param name="TargetControl">目标控件</param>
        /// <param name="TargetContainer">目标容器</param>
        public static void InputVerifyNotNull(TextBox TargetControl, Panel TargetContainer)
        {
            if (string.IsNullOrEmpty(TargetControl.Text))
            {
                LblInfo.AutoSize = true;
                LblInfo.Text = "必填！";
                LblInfo.TextAlign = ContentAlignment.BottomCenter;
                LblInfo.BackColor = Color.Yellow;
                LblInfo.Location = new Point(TargetControl.Left + TargetControl.Width + 2, TargetControl.Top);
                LblInfo.Font = new Font(LblInfo.Font.Name, 14.25f);
                TargetContainer.Controls.Add(LblInfo);
                LblInfo.Visible = true;
                //TargetControl.Focus();//锁定控件
            }
            else
            {
                LblInfo.Visible = false;

            }
        }

        //public static void InputVerifyNotNull( Panel TargetContainer,params TextBox[] TargetControls)
        //{
        //    foreach (TextBox TargetControl in TargetControls)
        //    {
        //        if (string.IsNullOrEmpty(TargetControl.Text))
        //        {
        //            LblInfo.AutoSize = true;
        //            LblInfo.Text = "不能为空！";
        //            LblInfo.BackColor = Color.Yellow;
        //            LblInfo.Location = new Point(TargetControl.Left + TargetControl.Width + 10, TargetControl.Top);
        //            LblInfo.Font = new Font(LblInfo.Font.Name, 14.25f);
        //            TargetContainer.Controls.Add(LblInfo);
        //            LblInfo.Visible = true;
        //            TargetControl.Focus();
        //        }
        //        else
        //        {
        //            LblInfo.Visible = false;

        //        }
        //    }
        //}

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
                        strLine += "\"\t"+col.HeaderText.Trim().Replace("\"", "\\\"")+"\"" + "\t";
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
                            strLine += "\"\t" + dgvc.Value.ToString().Trim().Replace("\"","\"\"") +"\"" + "\t";
                        }
                    }
                    }
                    sw.WriteLine(strLine);
                    sw.Flush();
                }
                sw.Close();
                MessageBox.Show(string.Format("数据已成功导出至\n{0}\n文件中!", strFileName), "导出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 生成默认的文名，格式：“前缀字符串”+“当前日期的数字编码”
        /// </summary>
        /// <param name="prefix">前缀字符串</param>
        /// <returns>默认文件名</returns>
        public static string GetDateNumber(string prefix)
        {
            prefix += DateTime.Now.ToString("yyyyMMdd");
            return prefix;
        }
    }
}
