using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSAP.DAO.BSDAO;
using System.Data;
using System.Data.SqlClient;
using PSAP;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;

namespace PSAP.BLL.BSBLL
{
    public abstract class BSBLL
    {
        /// <summary>
        /// 初始化主菜单用户权限
        /// </summary>
        /// 
        public static void InitUserMenus(MenuStrip mnuS)
        {
            ToolStripMenuItem mnuItem;
            ToolStripMenuItem refMenuItem = new ToolStripMenuItem();

            //初始设置所有菜单无效
            foreach (ToolStripMenuItem ctrl in mnuS.Items)
            {
                //ctrl.Enabled = false;//主菜单保持有效状态
                foreach (object subItem in ctrl.DropDownItems)
                {
                    if (subItem.GetType() == refMenuItem.GetType())
                    {
                        mnuItem = (ToolStripMenuItem)subItem;
                        mnuItem.Enabled = false;
                    }
                }
            }

            //取得相应用户对应的菜单项权限
            ENTITY.BSENTITY.UserInfo userInfo = new ENTITY.BSENTITY.UserInfo();
            string sqlString = "select a.MenuName from BS_UserRight a where a.LoginID like'" + userInfo.LoginID + "'";
            SqlDataAdapter adp = new SqlDataAdapter(sqlString, BaseSQL.connectionString);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            //设置菜单项的可见或可用性
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                //遍历主菜单
                foreach (ToolStripMenuItem ctrl in mnuS.Items)
                {
                    //主菜单保持有效状态
                    //if (ctrl.Name.ToUpper().Trim() == dr[0].ToString().ToUpper().Trim())
                    //{
                    //ctrl.Visible = true;
                    //ctrl.Enabled = true;
                    //break;
                    //}

                    //遍历子菜单
                    foreach (object subItem in ctrl.DropDownItems)
                    {
                        if (subItem.GetType() == refMenuItem.GetType())
                        {
                            mnuItem = (ToolStripMenuItem)subItem;
                            if (mnuItem.Name.ToUpper().Trim() == dr[0].ToString().ToUpper().Trim())
                            {
                                //mnuItem.Visible = true;
                                mnuItem.Enabled = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 设置窗口中按钮的权限(主方法)
        /// </summary>
        /// <param name="CurrentDockContent"></param>
        public static void SetFormRight(DockContent CurrentDockContent)
        {
            Control.ControlCollection CurrentControls = CurrentDockContent.Controls;
            SetFormButtonRight(CurrentControls, CurrentDockContent.Name);
        }
        /// <summary>
        /// 设置窗口中按钮的权限（SetFormRight子方法）
        /// </summary>
        /// <param name="CurrentControls"></param>
        /// <param name="strCurrentFormName"></param>
        public static void SetFormButtonRight(Control.ControlCollection CurrentControls, string strCurrentFormName)
        {
            foreach (Control n in CurrentControls)
            {
                if (n is Button)
                {
                    if (!FrmRightBLL.strNotRightButton.Contains(n.Name))
                    {
                        n.Enabled = false;//注释此行可关闭按钮权限设定【开发用】
                    }

                    DataTable dt = BSCommon.GetFormButtonRightData(FrmLoginDAO.user.AutoId.ToString(), strCurrentFormName, n.Name);//n.name==>button Name

                    //if (dt.Rows.Count != 0)
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr["ButtonName"].ToString() == n.Name)
                            {
                                n.Enabled = true;
                            }
                        }
                    }
                }
                if (n is ToolStrip)
                {
                    ToolStrip tsTmp = (ToolStrip)n;
                    for (int i = 0; i < tsTmp.Items.Count; i++)
                    {
                        if (tsTmp.Items[i].GetType().ToString() == "System.Windows.Forms.ToolStripButton")//判断是否为ToolStripButton
                        {
                            if (!FrmRightBLL.strNotRightButton.Contains(tsTmp.Items[i].Name))
                            {
                                tsTmp.Items[i].Enabled = false;
                            }
                            DataTable dt = BSCommon.GetFormButtonRightData(FrmLoginDAO.user.AutoId.ToString(), strCurrentFormName, tsTmp.Items[i].Name);//n.name==>button Name
                            if (dt != null)
                            {
                                foreach (DataRow dr in dt.Rows)
                                {
                                    if (dr["ButtonName"].ToString() == tsTmp.Items[i].Name)
                                    {
                                        tsTmp.Items[i].Enabled = true;
                                    }

                                }
                            }

                        }
                    }
                }
                if (n.Controls.Count > 0)
                {
                    SetFormButtonRight(n.Controls, strCurrentFormName);
                }
            }
        }

        #region 直接打印相关方法

        /// <summary>
        /// 用来记录当前打印到第几页了
        /// </summary>
        private static int m_currentPageIndex;

        /// <summary>
        /// 声明一个Stream对象的列表用来保存报表的输出数据,LocalReport对象的Render方法会将报表按页输出为多个Stream对象。
        /// </summary>
        private static IList<Stream> m_streams;

        private static bool isLandSapces = false;

        /// <summary>
        /// 用来提供Stream对象的函数，用于LocalReport对象的Render方法的第三个参数。
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fileNameExtension"></param>
        /// <param name="encoding"></param>
        /// <param name="mimeType"></param>
        /// <param name="willSeek"></param>
        /// <returns></returns>
        private static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            //如果需要将报表输出的数据保存为文件，请使用FileStream对象。
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        /// <summary>
        /// 为Report.rdlc创建本地报告加载数据,输出报告到.emf文件,并打印,同时释放资源
        /// </summary>
        /// <param name="rv">参数:ReportViewer.LocalReport</param>
        public static void PrintStream(LocalReport rvDoc)
        {
            //获取LocalReport中的报表页面方向
            isLandSapces = rvDoc.GetDefaultPageSettings().IsLandscape;
            Export(rvDoc);
            PrintSetting();
            Dispose();
        }

        private static void Export(LocalReport report)
        {
            string deviceInfo =
            @"<DeviceInfo>
                 <OutputFormat>EMF</OutputFormat>
             </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            //将报表的内容按照deviceInfo指定的格式输出到CreateStream函数提供的Stream中。
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }

        private static void PrintSetting()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("错误:没有检测到打印数据流");
            //声明PrintDocument对象用于数据的打印
            PrintDocument printDoc = new PrintDocument();
            //获取配置文件的清单打印机名称
            System.Configuration.AppSettingsReader appSettings = new System.Configuration.AppSettingsReader();
            printDoc.PrintController = new System.Drawing.Printing.StandardPrintController();//指定打印机不显示页码 
            //判断指定的打印机是否可用
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("错误:找不到打印机");
            }
            else
            {
                //设置打印机方向遵从报表方向
                printDoc.DefaultPageSettings.Landscape = isLandSapces;
                //声明PrintDocument对象的PrintPage事件，具体的打印操作需要在这个事件中处理。
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                //设置打印机打印份数
                printDoc.PrinterSettings.Copies = 1;
                //执行打印操作，Print方法将触发PrintPage事件。
                printDoc.Print();
            }
        }

        /// <summary>
        /// 处理程序PrintPageEvents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ev"></param>
        private static void PrintPage(object sender, PrintPageEventArgs ev)
        {
            //Metafile对象用来保存EMF或WMF格式的图形，
            //我们在前面将报表的内容输出为EMF图形格式的数据流。
            Metafile pageImage = new Metafile(m_streams[m_currentPageIndex]);

            //调整打印机区域的边距
            System.Drawing.Rectangle adjustedRect = new System.Drawing.Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            //绘制一个白色背景的报告
            //ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            //获取报告内容
            //这里的Graphics对象实际指向了打印机
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // 准备下一个页,已确定操作尚未结束
            m_currentPageIndex++;

            //设置是否需要继续打印
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        public static new void Dispose()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }

        #endregion
    }
}
