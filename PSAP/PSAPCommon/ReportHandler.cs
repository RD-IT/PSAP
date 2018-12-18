using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.PSAPCommon
{
    public class ReportHandler
    {
        /// <summary>
        /// 处理报表打印
        /// </summary>
        /// <param name="DefReport"></param>
        /// <param name="repxFileName"></param>
        /// <param name="outputdataset"></param>
        /// <param name="paralist"></param>
        /// <param name="handleType">处理类型：1 预览 2 打印 3 设计</param>
        public static void XtraReport_Handle(XtraReport DefReport, string repxFileName, DataSet outputdataset, List<Parameter> paralist, int handleType)
        {
            string path = "Report\\" + repxFileName;
            XtraReport report = new XtraReport();
            if (File.Exists(path))
                report.LoadLayout(path);
            else
            {
                if (DefReport == null)
                {
                    MessageHandler.ShowMessageBox("没有找到当前打印的模板文件，请检查软件的目录文件。");
                    return;
                }
                else
                    report = DefReport;
            }

            report.DataSource = outputdataset;
            if (paralist != null)
            {
                foreach (Parameter para in paralist)
                {
                    try
                    {
                        report.Parameters[para.Name].Value = para.Value;
                    }
                    catch
                    {
                        report.Parameters.Add(para);
                    }
                }
            }

            report.RequestParameters = false;

            report.CreateDocument();
            report.PrintingSystem.SetCommandVisibility(new PrintingSystemCommand[]{ PrintingSystemCommand.Find,
                    PrintingSystemCommand.Open,
                    PrintingSystemCommand.Parameters,
                    PrintingSystemCommand.Scale,
                    PrintingSystemCommand.Watermark,
                    PrintingSystemCommand.ExportMht,
                    PrintingSystemCommand.ExportXls ,
                    PrintingSystemCommand.ExportXlsx ,
                    PrintingSystemCommand.ExportPdf   ,
                    PrintingSystemCommand.ExportTxt  ,
                    PrintingSystemCommand.ExportRtf,
                    PrintingSystemCommand.ExportXps,
                    PrintingSystemCommand.ExportHtm,
                    PrintingSystemCommand.ExportGraphic,
                    PrintingSystemCommand.Zoom ,
                    PrintingSystemCommand.SendCsv,
                    PrintingSystemCommand.SendFile,
                    PrintingSystemCommand.SendGraphic,
                    PrintingSystemCommand.SendMht,
                    PrintingSystemCommand.SendPdf,
                    PrintingSystemCommand.SendRtf,
                    PrintingSystemCommand.SendTxt,
                    PrintingSystemCommand.SendXls,
                    PrintingSystemCommand.SendXlsx,
                    PrintingSystemCommand.SendXps,
                    PrintingSystemCommand.EditPageHF,
                    PrintingSystemCommand.ClosePreview,
                    PrintingSystemCommand.Scale,
                    PrintingSystemCommand.ExportCsv,
                    PrintingSystemCommand.FillBackground,
                    PrintingSystemCommand.HandTool,
                    PrintingSystemCommand.Zoom,
                    PrintingSystemCommand.Find ,
                    PrintingSystemCommand.PageSetup ,
                    PrintingSystemCommand.ShowFirstPage ,
                    PrintingSystemCommand.ShowLastPage,
                    PrintingSystemCommand.ZoomToPageWidth ,
                    PrintingSystemCommand.PageLayoutContinuous
            }, DevExpress.XtraPrinting.CommandVisibility.None);

            switch (handleType)
            {
                case 1:
                    XtraReport_Preview(report);
                    break;
                case 2:
                    XtraReport_Print(report);
                    break;
                case 3:
                    XtraReport_Designer(report, path);
                    break;
            }
        }

        public static void XtraReport_Preview(XtraReport report)
        {
            report.PrintingSystem.PageSettings.PrinterName = SystemInfo.DefaultPrinterName;
            report.ShowPreviewDialog();
        }

        public static void XtraReport_Print(XtraReport report)
        {
            report.Print(SystemInfo.DefaultPrinterName);
        }

        public static void XtraReport_Designer(XtraReport report, string path)
        {
            XRDesignFormEx designForm = new XRDesignFormEx();
            designForm.DesignPanel.SetCommandVisibility(new ReportCommand[]{
                ReportCommand.NewReport,
                ReportCommand.SaveFileAs,
                ReportCommand.NewReportWizard,
                ReportCommand.OpenFile
                }, DevExpress.XtraReports.UserDesigner.CommandVisibility.None);

            designForm.OpenReport(report);
            designForm.FileName = path;
            designForm.ShowDialog();
            designForm.Dispose();
        }

    }
}
