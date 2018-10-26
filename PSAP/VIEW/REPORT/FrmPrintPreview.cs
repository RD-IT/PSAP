using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Reporting.WinForms;

namespace PSAP.VIEW.BSVIEW  //REPORT
{
    public partial class FrmPrintPreview : Form //DockContent
    {

        public FrmPrintPreview(string path,string[] dsName,object[] ds)
        {
            InitializeComponent();
            LoadRDLC(path, dsName, ds);
        }

        /// <summary>
        /// 调用报表打印预览界面
        /// </summary>
        /// <param name="path">报表文件全路径文件名（扩展名）</param>
        /// <param name="dsName">报表中设定的数据集名</param>
        /// <param name="ds">数据集对象</param>
        public void LoadRDLC(string path, string[] dsName, object[] ds)
        {
            //设置打印布局模式,显示物理页面大小
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.LocalReport.ReportPath = path;
            for (int i=0; i < dsName.GetLength(0); i++) {
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(dsName[i], ds[i]));//要和设计报表时指定的名称一致
            }
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
