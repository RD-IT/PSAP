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
using System.Drawing;
using System.Xml;
using PsapUserControlLibrary;
using System.Reflection;
using System.Collections;

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
            SetDockContentStyle(CurrentDockContent);//调用窗口样式设定方法
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
                SetFormControlStyle(n);//调用窗口控件样式设定方法

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

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        #region 初始化样式变量
        static string FormBackColor;
        static string FormBackGroundImage;
        static string FormBackGroundImageLayout;
        static string FormForeColor;
        static string DockContentBackColor;
        static string DockContentBackGroundImage;
        static string DockContentBackGroundImageLayout;
        static string DockContentForeColor;
        static string ButtonBackColor;
        static string ButtonBackgroundImage;
        static string ButtonBackgroundImageLayout;
        static string ButtonForeColor;
        static string ButtonImage;
        static string ToolStripButtonDisplayStyle;//None|Text|Image|ImageAndText
        static string ToolStripButtonBackColor;//颜色名称
        static string ToolStripButtonBackgroundImage;//图片全名
        static string ToolStripButtonBackgroundImageLayout;//None|Tile|Center|Stretch|Zoom
        static string ToolStripButtonForeColor;
        static string ToolStripButtonImage;
        static string ToolStripButtonImageTransparentColor;//透明色名称
        static string LabelBACKCOLOR;
        static string LabelForeColor;
        static string LabelIimage;
        static string DataGridViewRowsDefaultCellStyleBackColor;
        static string DataGridViewRowsDefaultCellStyleForeColor;
        static string DataGridViewRowsDefaultCellStyleSelectionBackColor;
        static string DataGridViewRowsDefaultCellStyleSelectionForeColor;
        static string DataGridViewAlternatingRowsDefaultCellStyleBackColor;
        static string DataGridViewAlternatingRowsDefaultCellStyleForeColor;
        static string DataGridViewAlternatingRowsDefaultCellStyleSelectionBackColor;
        static string DataGridViewAlternatingRowsDefaultCellStyleSelectionForeColor;
        static string DataGridViewExRowsDefaultCellStyleBackColor;
        static string DataGridViewExRowsDefaultCellStyleForeColor;
        static string DataGridViewExRowsDefaultCellStyleSelectionBackColor;
        static string DataGridViewExRowsDefaultCellStyleSelectionForeColor;
        static string DataGridViewExAlternatingRowsDefaultCellStyleBackColor;
        static string DataGridViewExAlternatingRowsDefaultCellStyleForeColor;
        static string DataGridViewExAlternatingRowsDefaultCellStyleSelectionBackColor;
        static string DataGridViewExAlternatingRowsDefaultCellStyleSelectionForeColor;
        static string strTmp;


        /// <summary>
        /// 初始化主题变量
        /// </summary>
        /// <param name="dc"></param>
        public static void InitThemeVariable()
        {
            DataTable dtUserTheme = new DataTable();
            if (File.Exists(Application.StartupPath + "\\Theme.xml"))
            {
                dtUserTheme = XmlFileToDataTable(Application.StartupPath + "\\Theme.xml");
            }
            else
            {
                MessageBox.Show("用户主题配置文件丢失，请重新启动系统！");
                return;
            }

            foreach (DataRow dr in dtUserTheme.Rows)
            {
                //MessageBox.Show(dr[2] + "  " + dr[3] + "  " + dr[4]);

                //%%%%%%%%%%%%%%%%%%%%%%%%%
                if ((dr[2].ToString() + dr[3].ToString()).ToUpper() == ("buttonBackColor").ToUpper())
                {
                    ButtonBackColor = dr[4].ToString();
                }

                if ((dr[2].ToString() + dr[3].ToString()).ToUpper() == ("ButtonBackgroundImageLayout").ToUpper())
                {
                    ButtonBackgroundImageLayout = dr[4].ToString();
                }

                if ((dr[2].ToString() + dr[3].ToString()).ToUpper() == ("ButtonBackgroundImage").ToUpper())
                {
                    ButtonBackgroundImage = dr[4].ToString();
                }

                if ((dr[2].ToString() + dr[3].ToString()).ToUpper() == ("ButtonImage").ToUpper())
                {
                    ButtonImage = dr[4].ToString();
                }

                if ((dr[2].ToString() + dr[3].ToString()).ToUpper() == ("formBackColor").ToUpper())
                {
                    FormBackColor = dr[4].ToString();
                }

                if ((dr[2].ToString() + dr[3].ToString()).ToUpper() == ("DockContentBackColor").ToUpper())
                {
                    DockContentBackColor = dr[4].ToString();
                }

                if ((dr[2].ToString() + dr[3].ToString()).ToUpper() == ("ToolStripButtonBackColor").ToUpper())
                {
                    ToolStripButtonBackColor = dr[4].ToString();
                }

                if ((dr[2].ToString() + dr[3].ToString()).ToUpper() == ("DataGridViewRowsDefaultCellStyle.BackColor").ToUpper())
                {
                    DataGridViewRowsDefaultCellStyleBackColor = dr[4].ToString();
                }

                if ((dr[2].ToString() + dr[3].ToString()).ToUpper() == ("DataGridViewAlternatingRowsDefaultCellStyle.BackColor").ToUpper())
                {
                    DataGridViewAlternatingRowsDefaultCellStyleBackColor = dr[4].ToString();
                }

                if ((dr[2].ToString() + dr[3].ToString()).ToUpper() == ("DataGridViewExRowsDefaultCellStyle.BackColor").ToUpper())
                {
                    DataGridViewExRowsDefaultCellStyleBackColor = dr[4].ToString();
                }

                if ((dr[2].ToString() + dr[3].ToString()).ToUpper() == ("DataGridViewExAlternatingRowsDefaultCellStyle.BackColor").ToUpper())
                {
                    DataGridViewExAlternatingRowsDefaultCellStyleBackColor = dr[4].ToString();
                }

            }
        }

        #endregion
        //刷新用户主题配置文件
        public static void RefreshUserThemeConfigFile()
        {

            //if (!File.Exists(Application.StartupPath+@"\Theme.xml"))//Testing调试期间先不判断文件是否存在一律刷新文（修改主题文件时也应刷新）
            {
                //DataTable dt = new DataTable();
                //dt = PSAP.DAO.BSDAO.BSCommon.getThemeInfo();
                DataSet ds = new DataSet();
                ds.Tables.Add(PSAP.DAO.BSDAO.BSCommon.getThemeInfo());
                DataTableToXmlFile(ds.Tables[0], Application.StartupPath + "\\Theme.xml");
            }
        }

        // 将DataTable对象数据保存为XML文件
        public static bool DataTableToXmlFile(DataTable dt, string xmlFilePath)
        {
            if ((dt != null) && (!string.IsNullOrEmpty(xmlFilePath)))
            {
                StringWriter writer = new StringWriter();
                dt.WriteXml(writer);
                string xmlstr = writer.ToString();
                writer.Close();
                File.WriteAllText(xmlFilePath, xmlstr);//不存在该XML文件时会自动生成一个文件
                return true;
            }
            else
            {
                return false;
            }
        }

        //将Theme.xml文件中的数据，装入到DataTable对象中
        public static DataTable XmlFileToDataTable(string xmlFilePath)
        {
            if (!string.IsNullOrEmpty(xmlFilePath))
            {

                try
                {
                    DataSet dtTmp = new DataSet();
                    dtTmp.ReadXml(xmlFilePath);
                    return dtTmp.Tables[0];
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                return null;
            }


        }

        /// <summary>
        /// 设置DockContent窗口样式
        /// </summary>
        /// <param name="dc"></param>
        public static void SetDockContentStyle(DockContent dc)
        {
            //DockContent样式
            if (!string.IsNullOrEmpty(DockContentBackColor) && DockContentBackColor != "-")
            {
                dc.BackColor = Color.FromName(DockContentBackColor);
            }
        }

        /// <summary>
        ///设置窗口控件样式 
        /// </summary>
        /// <param name="n"></param>
        public static void SetFormControlStyle(Control n)
        {
            if (n is Panel || n is ToolStrip || n is BindingNavigator)
            {
                n.BackColor = Color.Transparent;
                //((ToolStrip)n).
            }

            if (n is Button)
            {
                n.BackgroundImageLayout = ImageLayout.Stretch; //默认拉伸

                strTmp = ButtonBackColor;
                if (!string.IsNullOrEmpty(strTmp) && strTmp != "-")
                { n.BackColor = Color.FromName(strTmp); }

                strTmp = ButtonBackgroundImage;
                if (!string.IsNullOrEmpty(strTmp) && strTmp != "-")
                { n.BackgroundImage = Image.FromFile(Application.StartupPath + "\\skin\\" + strTmp); }

                strTmp = ButtonImage;
                if (!string.IsNullOrEmpty(strTmp) && strTmp != "-")
                { ((Button)n).Image = Image.FromFile(Application.StartupPath + "\\skin\\" + strTmp); }

            }

            if (n is ToolStrip)
            {
                ToolStrip tsTmp = (ToolStrip)n;
                for (int i = 0; i < tsTmp.Items.Count; i++)
                {
                    if (tsTmp.Items[i].GetType().ToString() == "System.Windows.Forms.ToolStripButton")//判断是否为ToolStripButton
                    {
                        strTmp = ToolStripButtonBackColor;
                        if (!string.IsNullOrEmpty(strTmp) && strTmp != "-")
                        { tsTmp.Items[i].BackColor = Color.FromName(strTmp); }
                    }
                }
            }

            if (n is TabPage)
            {
                strTmp = DockContentBackColor;
                if (!string.IsNullOrEmpty(strTmp) && strTmp != "-")
                { n.BackColor = Color.FromName(strTmp); }
            }

            if (n is DataGridView)
            {
                strTmp = DataGridViewRowsDefaultCellStyleBackColor;
                if (!string.IsNullOrEmpty(strTmp) && strTmp != "-")
                {
                    ((DataGridView)n).RowsDefaultCellStyle.BackColor = Color.FromName(strTmp);
                }

                strTmp = DataGridViewAlternatingRowsDefaultCellStyleBackColor;
                if (!string.IsNullOrEmpty(strTmp) && strTmp != "-")
                {
                    ((DataGridView)n).AlternatingRowsDefaultCellStyle.BackColor = Color.FromName(strTmp);
                }
            }

            if (n is DataGridViewEx)
            {
                strTmp = DataGridViewExRowsDefaultCellStyleBackColor;
                if (!string.IsNullOrEmpty(strTmp) && strTmp != "-")
                {
                    ((DataGridViewEx)n).RowsDefaultCellStyle.BackColor = Color.FromName(strTmp);
                }

                strTmp = DataGridViewExAlternatingRowsDefaultCellStyleBackColor;
                if (!string.IsNullOrEmpty(strTmp) && strTmp != "-")
                {
                    ((DataGridViewEx)n).AlternatingRowsDefaultCellStyle.BackColor = Color.FromName(strTmp);
                }
            }

        }

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

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

        public static void Dispose()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }

        #endregion

        #region 多语言系统功能%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

        /// <summary>
        /// 遍历窗口及其中控件,并将结果加至数据库表中
        /// </summary>
        public static void TraverseFormControlToTable()
        {

            DockContent DockContentFormN = new DockContent();
            Form FormN = new Form();
            Assembly a = Assembly.LoadFile(Application.ExecutablePath);//.net中的反射
            Type[] types = a.GetTypes();
            DataTable dt = new DataTable();
            BSCommon.TraverseControlTextStart();
            foreach (Type t in types)
            {

                if (t.BaseType.Name == "DockContent")
                {
                    DockContentFormN = (DockContent)Activator.CreateInstance(t, true);
                    if (DockContentFormN.Text != null && DockContentFormN.Text != string.Empty)
                    {
                        //1.1
                        //BSCommon.TraverseControlTextAdd(DockContentFormN.Name, t.BaseType.Name, DockContentFormN.Name, DockContentFormN.Text, "Text");
                        BSCommon.TraverseControlTextAdd(DockContentFormN.Name, t.BaseType.Name, DockContentFormN.Name, DockContentFormN.TabText, "TabText");

                    }

                    //MessageBox.Show(DockContectFormN.Text + " | " + DockContectFormN.Name);
                    foreach (Control ctl in DockContentFormN.Controls)//遍历所有“DockContent”窗口
                    {
                        if (ctl.Text != null && ctl.Text != string.Empty && ctl.Text != '0'.ToString() && ctl.Name != string.Empty)
                        {
                            //1.2
                            BSCommon.TraverseControlTextAdd(DockContentFormN.Name, ctl.GetType().Name, ctl.Name, ctl.Text, "Text");
                        }

                        if (ctl is DataGridView)
                        {
                            DataGridView dg = (DataGridView)ctl;
                            foreach (object ch in dg.Columns)
                            {
                                {
                                    if (ch.GetType().Name == "DataGridViewTextBoxColumn")
                                    {
                                        //MessageBox.Show(((DataGridViewTextBoxColumn)ch).HeaderText + "!!!!!!!!!!" + ((DataGridViewTextBoxColumn)ch).ToolTipText);
                                        //4.1.1
                                        BSCommon.TraverseControlTextAdd(DockContentFormN.Name, ch.GetType().Name, ((DataGridViewTextBoxColumn)ch).Name, ((DataGridViewTextBoxColumn)ch).HeaderText, "HeaderText");

                                    }
                                    if (ch.GetType().Name == "DataGridViewComboBoxColumn")
                                    {
                                        //MessageBox.Show(((DataGridViewComboBoxColumn)ch).HeaderText + "???????");
                                        //4.1.2
                                        BSCommon.TraverseControlTextAdd(DockContentFormN.Name, ch.GetType().Name, ((DataGridViewComboBoxColumn)ch).Name, ((DataGridViewComboBoxColumn)ch).HeaderText, "HeaderText");
                                    }
                                }
                            }
                        }


                        if (ctl is ToolStrip)
                        {
                            ToolStrip tsTmp = (ToolStrip)ctl;
                            for (int i = 0; i < tsTmp.Items.Count; i++)
                            {
                                if (tsTmp.Items[i].GetType().Name == "ToolStripButton")//判断是否为ToolStripButton
                                {
                                    if (tsTmp.Items[i].Text != string.Empty)
                                    {
                                        //1.3
                                        BSCommon.TraverseControlTextAdd(DockContentFormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].Text, "Text");
                                        BSCommon.TraverseControlTextAdd(DockContentFormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].ToolTipText, "ToolTipText");
                                    }
                                }
                            }
                        }

                        if (ctl.Controls.Count > 0)
                        {
                            TraverseFormControls(DockContentFormN, ctl);
                        }
                    }
                }

                //****************************Form
                if (t.BaseType.Name == "Form")
                {
                    FormN = (Form)Activator.CreateInstance(t, true);

                    if (FormN.Text != null && DockContentFormN.Text != string.Empty)
                    {
                        //2.1
                        BSCommon.TraverseControlTextAdd(FormN.Name, t.BaseType.Name, FormN.Name, FormN.Text, "Text");
                    }

                    //MessageBox.Show(DockContectFormN.Text + " | " + DockContectFormN.Name);
                    foreach (Control ctl in FormN.Controls)//遍历所有“DockContent”窗口
                    {
                        if (ctl.Text != null && ctl.Text != string.Empty && ctl.Text != '0'.ToString() && ctl.Name != string.Empty)
                        {
                            //2.2
                            BSCommon.TraverseControlTextAdd(FormN.Name, ctl.GetType().Name, ctl.Name, ctl.Text, "Text");
                        }

                        if (ctl is DataGridView)
                        {
                            DataGridView dg = (DataGridView)ctl;
                            foreach (object ch in dg.Columns)
                            {
                                {
                                    if (ch.GetType().Name == "DataGridViewTextBoxColumn")
                                    {
                                        //MessageBox.Show(((DataGridViewTextBoxColumn)ch).HeaderText + "!!!!!!!!!!" + ((DataGridViewTextBoxColumn)ch).ToolTipText);
                                        //4.1.1
                                        BSCommon.TraverseControlTextAdd(FormN.Name, ch.GetType().Name, ((DataGridViewTextBoxColumn)ch).Name, ((DataGridViewTextBoxColumn)ch).HeaderText, "HeaderText");

                                    }
                                    if (ch.GetType().Name == "DataGridViewComboBoxColumn")
                                    {
                                        //MessageBox.Show(((DataGridViewComboBoxColumn)ch).HeaderText + "???????");
                                        //4.1.2
                                        BSCommon.TraverseControlTextAdd(FormN.Name, ch.GetType().Name, ((DataGridViewComboBoxColumn)ch).Name, ((DataGridViewComboBoxColumn)ch).HeaderText, "HeaderText");
                                    }
                                }
                            }
                        }


                        if (ctl is ToolStrip)
                        {
                            ToolStrip tsTmp = (ToolStrip)ctl;
                            for (int i = 0; i < tsTmp.Items.Count; i++)
                            {
                                if (tsTmp.Items[i].GetType().ToString() == "System.Windows.Forms.ToolStripButton")//判断是否为ToolStripButton
                                {
                                    if (tsTmp.Items[i].Text != string.Empty)
                                    {
                                        //2.3
                                        BSCommon.TraverseControlTextAdd(FormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].Text, "Text");
                                        BSCommon.TraverseControlTextAdd(FormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].ToolTipText, "ToolTipText");

                                    }
                                }
                            }
                        }

                        if (ctl.Controls.Count > 0)
                        {
                            TraverseFormControls(FormN, ctl);
                        }
                    }
                }
                //*************Form
            }
            BSCommon.TraverseControlTextSave();//以事务方式执行拼接好的sql语句组
        }

        /// <summary>
        /// 遍历DockContent窗口控件
        /// </summary>
        /// <param name="DockContentFormN"></param>
        /// <param name="ctlTmp"></param>
        public static void TraverseFormControls(DockContent DockContentFormN, Control ctlTmp)
        {
            foreach (Control n in ctlTmp.Controls)
            {
                if (n.Text != null && n.Text != string.Empty && n.Text != '0'.ToString() && n.Name != string.Empty)
                {
                    //3.1
                    BSCommon.TraverseControlTextAdd(DockContentFormN.Name, n.GetType().Name, n.Name, n.Text, "Text");

                }

                if (n is DataGridView)
                {
                    DataGridView dg = (DataGridView)n;
                    foreach (object ch in dg.Columns)
                    {
                        {
                            if (ch.GetType().Name == "DataGridViewTextBoxColumn")
                            {
                                //MessageBox.Show(((DataGridViewTextBoxColumn)ch).HeaderText + "!!!!!!!!!!" + ((DataGridViewTextBoxColumn)ch).ToolTipText);
                                //3.1.1
                                BSCommon.TraverseControlTextAdd(DockContentFormN.Name, ch.GetType().Name, ((DataGridViewTextBoxColumn)ch).Name, ((DataGridViewTextBoxColumn)ch).HeaderText, "HeaderText");

                            }
                            if (ch.GetType().Name == "DataGridViewComboBoxColumn")
                            {
                                //MessageBox.Show(((DataGridViewComboBoxColumn)ch).HeaderText + "???????");
                                //3.1.2
                                BSCommon.TraverseControlTextAdd(DockContentFormN.Name, ch.GetType().Name, ((DataGridViewComboBoxColumn)ch).Name, ((DataGridViewComboBoxColumn)ch).HeaderText, "HeaderText");
                            }
                        }
                    }
                }

                if (n is ToolStrip)
                {
                    ToolStrip tsTmp = (ToolStrip)n;
                    for (int i = 0; i < tsTmp.Items.Count; i++)
                    {
                        if (tsTmp.Items[i].GetType().Name == "ToolStripButton")//判断是否为ToolStripButton
                        {
                            //MessageBox.Show(DockContentFormN.Name + "==>" + tsTmp.Items[i].Text + "==>" + tsTmp.Items[i].Name + tsTmp.Items[i].ToolTipText);
                            if (tsTmp.Items[i].Text != string.Empty)
                            {
                                //3.3
                                BSCommon.TraverseControlTextAdd(DockContentFormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].Text, "Text");
                                BSCommon.TraverseControlTextAdd(DockContentFormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].ToolTipText, "ToolTipText");
                            }
                        }
                    }
                }


                if (n.Controls.Count > 0)
                {
                    TraverseFormControls(DockContentFormN, n);
                }
            }
        }
        //Form---------------------------------------------
        public static void TraverseFormControls(Form FormN, Control ctlTmp)
        {
            foreach (Control n in ctlTmp.Controls)
            {
                if (n.Text != null && n.Text != string.Empty && n.Text != '0'.ToString() && n.Name != string.Empty)
                {
                    //MessageBox.Show(n.Text);
                    //4.2
                    BSCommon.TraverseControlTextAdd(FormN.Name, n.GetType().Name, n.Name, n.Text, "Text");

                }

                if (n is DataGridView)
                {
                    DataGridView dg = (DataGridView)n;
                    foreach (object ch in dg.Columns)
                    {
                        {
                            if (ch.GetType().Name == "DataGridViewTextBoxColumn")
                            {
                                //MessageBox.Show(((DataGridViewTextBoxColumn)ch).HeaderText + "!!!!!!!!!!" + ((DataGridViewTextBoxColumn)ch).ToolTipText);
                                //4.1.1
                                BSCommon.TraverseControlTextAdd(FormN.Name, ch.GetType().Name, ((DataGridViewTextBoxColumn)ch).Name, ((DataGridViewTextBoxColumn)ch).HeaderText, "HeaderText");

                            }
                            if (ch.GetType().Name == "DataGridViewComboBoxColumn")
                            {
                                //MessageBox.Show(((DataGridViewComboBoxColumn)ch).HeaderText + "???????");
                                //4.1.2
                                BSCommon.TraverseControlTextAdd(FormN.Name, ch.GetType().Name, ((DataGridViewComboBoxColumn)ch).Name, ((DataGridViewComboBoxColumn)ch).HeaderText, "HeaderText");
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
                            //MessageBox.Show(DockContentFormN.Name + "==>" + tsTmp.Items[i].Text + "==>" + tsTmp.Items[i].Name);
                            if (tsTmp.Items[i].Text != string.Empty)
                            {
                                //4.3
                                BSCommon.TraverseControlTextAdd(FormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].Text, "Text");
                                BSCommon.TraverseControlTextAdd(FormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].ToolTipText, "ToolTipText");

                            }
                        }
                    }
                }


                if (n.Controls.Count > 0)
                {
                    TraverseFormControls(FormN, n);
                }
            }
        }
        //*************************************************************************
        //语种设置*****************************************************************
        //*************************************************************************

        /// <summary>
        /// 设置窗口语种DockContent(主方法)
        /// </summary>
        public static void SetFormLanguages(DockContent DockContentFormN)
        {
            DataTable dt = new DataTable();
            dt = BSCommon.GetFormLanuageData(DockContentFormN.Name);

            var TextValue = BSCommon.LocationControlsText(dt, DockContentFormN.Name, "TabText");
            if (TextValue.ToList().Count > 0)
            {
                DockContentFormN.TabText = TextValue.ToList().First().Field<string>("LanguageText");
            }

            foreach (Control ctl in DockContentFormN.Controls)//遍历所有“DockContent”窗口控件
            {

                if (ctl.Text != null && ctl.Text != string.Empty && ctl.Text != '0'.ToString() && ctl.Name != string.Empty)
                {
                    TextValue = BSCommon.LocationControlsText(dt, ctl.Name, "Text");
                    if (TextValue.ToList().Count > 0)
                    {
                        ctl.Text = TextValue.ToList().First().Field<string>("LanguageText");
                    }
                    //1.2
                    //BSCommon.TraverseControlTextAdd(DockContentFormN.Name, ctl.GetType().Name, ctl.Name, ctl.Text, "Text");
                }

                if (ctl is DataGridView)
                {
                    DataGridView dg = (DataGridView)ctl;
                    foreach (object ch in dg.Columns)
                    {
                        {
                            if (ch.GetType().Name == "DataGridViewTextBoxColumn")
                            {
                                TextValue = BSCommon.LocationControlsText(dt, ((DataGridViewTextBoxColumn)ch).Name, "HeaderText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    ((DataGridViewTextBoxColumn)ch).HeaderText = TextValue.ToList().First().Field<string>("LanguageText");
                                }
                                //3.1.1

                            }
                            if (ch.GetType().Name == "DataGridViewComboBoxColumn")
                            {
                                TextValue = BSCommon.LocationControlsText(dt, ((DataGridViewComboBoxColumn)ch).Name, "HeaderText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    ((DataGridViewComboBoxColumn)ch).HeaderText = TextValue.ToList().First().Field<string>("LanguageText");
                                }

                                //3.1.2
                            }
                        }
                    }
                }

                if (ctl is ToolStrip)
                {
                    ToolStrip tsTmp = (ToolStrip)ctl;
                    for (int i = 0; i < tsTmp.Items.Count; i++)
                    {
                        if (tsTmp.Items[i].GetType().Name == "ToolStripButton")//判断是否为ToolStripButton
                        {
                            if (tsTmp.Items[i].Text != string.Empty)
                            {
                                TextValue = BSCommon.LocationControlsText(dt, tsTmp.Items[i].Name, "Text");
                                if (TextValue.ToList().Count > 0)
                                {
                                    tsTmp.Items[i].Text = TextValue.ToList().First().Field<string>("LanguageText");
                                }

                                TextValue = BSCommon.LocationControlsText(dt, tsTmp.Items[i].Name, "ToolTipText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    tsTmp.Items[i].ToolTipText = TextValue.ToList().First().Field<string>("LanguageText");
                                }

                                //1.3
                                //BSCommon.TraverseControlTextAdd(DockContentFormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].Text, "Text");
                                //BSCommon.TraverseControlTextAdd(DockContentFormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].ToolTipText, "ToolTipText");
                            }
                        }
                    }
                }

                if (ctl.Controls.Count > 0)
                {
                    SetFormControlsLanuages(DockContentFormN, ctl);
                }
            }
        }


        /// <summary>
        /// 设置窗口语种Form(主方法)
        /// </summary>
        public static void SetFormLanguages(Form FormN)
        {
            DataTable dt = new DataTable();
            dt = BSCommon.GetFormLanuageData(FormN.Name);
            var TextValue = BSCommon.LocationControlsText(dt, FormN.Name, "Text");
            if (TextValue.ToList().Count > 0)
            {
                FormN.Text = TextValue.ToList().First().Field<string>("LanguageText");
            }

            foreach (Control ctl in FormN.Controls)//遍历所有“DockContent”窗口
            {
                if (ctl.Text != null && ctl.Text != string.Empty && ctl.Text != '0'.ToString() && ctl.Name != string.Empty)
                {
                    TextValue = BSCommon.LocationControlsText(dt, ctl.Name, "Text");
                    if (TextValue.ToList().Count > 0)
                    {
                        ctl.Text = TextValue.ToList().First().Field<string>("LanguageText");
                    }
                    //2.2
                    //BSCommon.TraverseControlTextAdd(FormN.Name, ctl.GetType().Name, ctl.Name, ctl.Text, "Text");
                }

                if (ctl is DataGridView)
                {
                    DataGridView dg = (DataGridView)ctl;
                    foreach (object ch in dg.Columns)
                    {
                        {
                            if (ch.GetType().Name == "DataGridViewTextBoxColumn")
                            {
                                TextValue = BSCommon.LocationControlsText(dt, ((DataGridViewTextBoxColumn)ch).Name, "HeaderText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    ((DataGridViewTextBoxColumn)ch).HeaderText = TextValue.ToList().First().Field<string>("LanguageText");
                                }
                                //3.1.1

                            }
                            if (ch.GetType().Name == "DataGridViewComboBoxColumn")
                            {
                                TextValue = BSCommon.LocationControlsText(dt, ((DataGridViewComboBoxColumn)ch).Name, "HeaderText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    ((DataGridViewComboBoxColumn)ch).HeaderText = TextValue.ToList().First().Field<string>("LanguageText");
                                }

                                //3.1.2
                            }
                        }
                    }
                }


                if (ctl is ToolStrip)
                {
                    ToolStrip tsTmp = (ToolStrip)ctl;
                    for (int i = 0; i < tsTmp.Items.Count; i++)
                    {
                        if (tsTmp.Items[i].GetType().ToString() == "System.Windows.Forms.ToolStripButton")//判断是否为ToolStripButton
                        {
                            if (tsTmp.Items[i].Text != string.Empty)
                            {
                                TextValue = BSCommon.LocationControlsText(dt, tsTmp.Items[i].Name, "Text");
                                if (TextValue.ToList().Count > 0)
                                {
                                    tsTmp.Items[i].Text = TextValue.ToList().First().Field<string>("LanguageText");
                                }

                                TextValue = BSCommon.LocationControlsText(dt, tsTmp.Items[i].Name, "ToolTipText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    tsTmp.Items[i].ToolTipText = TextValue.ToList().First().Field<string>("LanguageText");
                                }

                                //2.3
                                //BSCommon.TraverseControlTextAdd(FormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].Text, "Text");
                                //BSCommon.TraverseControlTextAdd(FormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].ToolTipText, "ToolTipText");

                            }
                        }
                    }
                }

                if (ctl.Controls.Count > 0)
                {
                    SetFormControlsLanuages(FormN, ctl);
                }
            }
        }


        //-----------------------
        /// <summary>
        /// 设置窗口（DockContent）语种（子方法）
        /// </summary>
        /// <param name="DockContentFormN"></param>
        /// <param name="ctlTmp"></param>
        public static void SetFormControlsLanuages(DockContent DockContentFormN, Control ctlTmp)
        {
            DataTable dt = new DataTable();
            dt = BSCommon.GetFormLanuageData(DockContentFormN.Name);

            foreach (Control n in ctlTmp.Controls)
            {
                if (n.Text != null && n.Text != string.Empty && n.Text != '0'.ToString() && n.Name != string.Empty)
                {
                    var TextValue = BSCommon.LocationControlsText(dt, n.Name, "Text");
                    if (TextValue.ToList().Count > 0)
                    {
                        n.Text = TextValue.ToList().First().Field<string>("LanguageText");
                    }
                    //3.1

                }

                if (n is DataGridView)
                {
                    DataGridView dg = (DataGridView)n;
                    foreach (object ch in dg.Columns)
                    {
                        {
                            if (ch.GetType().Name == "DataGridViewTextBoxColumn")
                            {
                                var TextValue = BSCommon.LocationControlsText(dt, ((DataGridViewTextBoxColumn)ch).Name, "HeaderText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    ((DataGridViewTextBoxColumn)ch).HeaderText = TextValue.ToList().First().Field<string>("LanguageText");
                                }
                                //3.1.1

                            }
                            if (ch.GetType().Name == "DataGridViewComboBoxColumn")
                            {
                                var TextValue = BSCommon.LocationControlsText(dt, ((DataGridViewComboBoxColumn)ch).Name, "HeaderText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    ((DataGridViewComboBoxColumn)ch).HeaderText = TextValue.ToList().First().Field<string>("LanguageText");
                                }

                                //3.1.2
                            }
                        }
                    }
                }

                if (n is ToolStrip)
                {
                    ToolStrip tsTmp = (ToolStrip)n;
                    for (int i = 0; i < tsTmp.Items.Count; i++)
                    {
                        if (tsTmp.Items[i].GetType().Name == "ToolStripButton")//判断是否为ToolStripButton
                        {
                            if (tsTmp.Items[i].Text != string.Empty)
                            {
                                var TextValue = BSCommon.LocationControlsText(dt, tsTmp.Items[i].Name, "Text");
                                if (TextValue.ToList().Count > 0)
                                {
                                    tsTmp.Items[i].Text = TextValue.ToList().First().Field<string>("LanguageText");
                                }

                                TextValue = BSCommon.LocationControlsText(dt, tsTmp.Items[i].Name, "ToolTipText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    tsTmp.Items[i].ToolTipText = TextValue.ToList().First().Field<string>("LanguageText");
                                }
                                //3.3
                                //BSCommon.TraverseControlTextAdd(DockContentFormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].Text, "Text");
                                //BSCommon.TraverseControlTextAdd(DockContentFormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].ToolTipText, "ToolTipText");
                            }
                        }
                    }
                }

                if (n.Controls.Count > 0)
                {
                    SetFormControlsLanuages(DockContentFormN, n);
                }
            }
        }
        //Form---------------------------------------------
        /// <summary>
        /// 设置窗口（Form）语种（子方法）
        /// </summary>
        /// <param name="FormN"></param>
        /// <param name="ctlTmp"></param>
        public static void SetFormControlsLanuages(Form FormN, Control ctlTmp)
        {
            DataTable dt = new DataTable();
            dt = BSCommon.GetFormLanuageData(FormN.Name);

            foreach (Control n in ctlTmp.Controls)
            {
                if (n.Text != null && n.Text != string.Empty && n.Text != '0'.ToString() && n.Name != string.Empty)
                {
                    var TextValue = BSCommon.LocationControlsText(dt, n.Name, "Text");
                    if (TextValue.ToList().Count > 0)
                    {
                        n.Text = TextValue.ToList().First().Field<string>("LanguageText");
                    }
                    //4.2
                    //BSCommon.TraverseControlTextAdd(FormN.Name, n.GetType().Name, n.Name, n.Text, "Text");

                }

                if (n is DataGridView)
                {
                    DataGridView dg = (DataGridView)n;
                    foreach (object ch in dg.Columns)
                    {
                        {
                            if (ch.GetType().Name == "DataGridViewTextBoxColumn")
                            {
                                var TextValue = BSCommon.LocationControlsText(dt, ((DataGridViewTextBoxColumn)ch).Name, "HeaderText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    ((DataGridViewTextBoxColumn)ch).HeaderText = TextValue.ToList().First().Field<string>("LanguageText");
                                }
                                //4.1.1
                                //BSCommon.TraverseControlTextAdd(FormN.Name, ch.GetType().Name, ((DataGridViewTextBoxColumn)ch).Name, ((DataGridViewTextBoxColumn)ch).HeaderText, "Text");
                            }
                            if (ch.GetType().Name == "DataGridViewComboBoxColumn")
                            {

                                var TextValue = BSCommon.LocationControlsText(dt, ((DataGridViewComboBoxColumn)ch).Name, "HeaderText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    ((DataGridViewComboBoxColumn)ch).HeaderText = TextValue.ToList().First().Field<string>("LanguageText");
                                }
                                //4.1.2
                                //BSCommon.TraverseControlTextAdd(FormN.Name, ch.GetType().Name, ((DataGridViewComboBoxColumn)ch).Name, ((DataGridViewComboBoxColumn)ch).HeaderText, "Text");
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
                            //MessageBox.Show(DockContentFormN.Name + "==>" + tsTmp.Items[i].Text + "==>" + tsTmp.Items[i].Name);
                            if (tsTmp.Items[i].Text != string.Empty)
                            {
                                var TextValue = BSCommon.LocationControlsText(dt, tsTmp.Items[i].Name, "Text");
                                if (TextValue.ToList().Count > 0)
                                {
                                    tsTmp.Items[i].Text = TextValue.ToList().First().Field<string>("LanguageText");
                                }

                                TextValue = BSCommon.LocationControlsText(dt, tsTmp.Items[i].Name, "ToolTipText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    tsTmp.Items[i].ToolTipText = TextValue.ToList().First().Field<string>("LanguageText");
                                }
                                //4.3
                                //BSCommon.TraverseControlTextAdd(FormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].Text, "Text");
                                //BSCommon.TraverseControlTextAdd(FormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].ToolTipText, "ToolTipText");
                            }
                        }
                    }
                }

                if (n.Controls.Count > 0)
                {
                    SetFormControlsLanuages(FormN, n);
                }
            }
        }

        ///// <summary>
        ///// 设置窗口语种
        ///// </summary>
        ///// <param name="dc"></param>
        //public static void SetFormsLanuage(DockContent dc)
        //{
        //    //DockContent语种

        //}

        #endregion

    }
}
