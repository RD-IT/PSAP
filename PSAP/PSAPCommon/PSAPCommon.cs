using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using PsapUserControlLibrary;

namespace PSAP.PSAPCommon
{
    public abstract class psapCommon
    {
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

        //public static Label LblInfo = new Label();//信息标签
        ///// <summary>
        ///// 判断目标文本框是否为空
        ///// </summary>
        ///// <param name="TargetControl">目标控件</param>
        ///// <param name="TargetContainer">目标容器</param>
        //public static void InputVerifyNotNull(TextBox TargetControl, Panel TargetContainer)
        //{
        //    if (string.IsNullOrEmpty(TargetControl.Text))
        //    {
        //        LblInfo.AutoSize = true;
        //        LblInfo.Text = "必填！";
        //        LblInfo.TextAlign = ContentAlignment.BottomCenter;
        //        LblInfo.BackColor = Color.Yellow;
        //        LblInfo.Location = new Point(TargetControl.Left + TargetControl.Width + 2, TargetControl.Top);
        //        LblInfo.Font = new Font(LblInfo.Font.Name, 14.25f);
        //        TargetContainer.Controls.Add(LblInfo);
        //        LblInfo.Visible = true;
        //        //TargetControl.Focus();//锁定控件
        //    }
        //    else
        //    {
        //        LblInfo.Visible = false;

        //    }
        //}


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

        /// <summary>
        /// 根据节点name定位树节点
        /// </summary>
        /// <param name="tvtbTmp"></param>
        /// <param name="strTreeNodeName"></param>
        public static void PositionTreeViewExNode(TreeViewToolBoxEx tvtbTmp, string strTreeNodeName)
        {
            foreach (TreeNode tn in tvtbTmp.Nodes)
            {
                if (tn.Name == strTreeNodeName)
                {
                    tvtbTmp.SelectedNode = tn;
                    return;
                }
                SubNode(tn, tvtbTmp, strTreeNodeName);
            }
        }

        //子过程
        public static void SubNode(TreeNode tn, TreeViewToolBoxEx tvtbTmp, string strTreeNodeName)
        {
            foreach (TreeNode tnSub in tn.Nodes)
            {
                if (tnSub.Name == strTreeNodeName)
                {
                    tvtbTmp.SelectedNode = tnSub;
                    return;
                }
                SubNode(tnSub, tvtbTmp, strTreeNodeName);
            }
        }

        /// <summary>
        /// 文本框只能输入数值型文本
        /// </summary>
        /// <param name="tn"></param>
        /// <param name="tvtbTmp"></param>
        /// <param name="strTreeNodeName"></param>
        public static void TextBoxOnlyInputNumeric(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if
            (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) &&
           (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true; //小数点的处理。
            if ((int)e.KeyChar == 46) //小数点
            {
                if (((TextBox)sender).Text.Length <= 0)
                    e.Handled = true; //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(((TextBox)sender).Text, out oldf);
                    b2 = float.TryParse(((TextBox)sender).Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
    }
}
