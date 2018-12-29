using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using PSAP.DAO.BSDAO;
using PSAP.DAO.PURDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static void XtraReport_Handle(XtraReport DefReport, string tableNameStr, DataSet outputdataset, List<Parameter> paralist, int handleType)
        {
            FrmDocumentTempletDAO docDAO = new FrmDocumentTempletDAO();
            DataTable docTempletTable = docDAO.QueryDocTemplet(tableNameStr);
            if(docTempletTable.Rows.Count==0)
            {
                MessageHandler.ShowMessageBox("未查询到当前单据模板的信息记录，操作错误。");
                return;
            }

            string path = DataTypeConvert.GetString(docTempletTable.Rows[0]["DocPath"]) + DataTypeConvert.GetString(docTempletTable.Rows[0]["DocFileName"]);
            string docVerStr = DataTypeConvert.GetString(docTempletTable.Rows[0]["DocVersion"]);

            string iniPath = "Report\\DocTemplet.ini";
            string sectionStr = "DocTemplet";
            if (File.Exists(path))
            {
                if (File.Exists(iniPath))
                {
                    string localVerStr = FileHandler.IniReadValue(iniPath, sectionStr, tableNameStr);
                    if (localVerStr != docVerStr && handleType != 3)
                    {
                        Byte[] fileByte = docDAO.QueryDocTemplet_FileByte(tableNameStr);
                        FileHandler.ByteArrayToFile(fileByte, path);
                        FileHandler.IniWriteValue(iniPath, sectionStr, tableNameStr, docVerStr);
                    }
                }
                else
                {
                    Byte[] fileByte = docDAO.QueryDocTemplet_FileByte(tableNameStr);
                    FileHandler.ByteArrayToFile(fileByte, path);
                    FileHandler.IniWriteValue(iniPath, sectionStr, tableNameStr, docVerStr);
                }
            }
            else
            {
                Byte[] fileByte = docDAO.QueryDocTemplet_FileByte(tableNameStr);
                FileHandler.ByteArrayToFile(fileByte, path);
                FileHandler.IniWriteValue(iniPath, sectionStr, tableNameStr, docVerStr);
            }
            XtraReport report = new XtraReport();
            report.LoadLayout(path);

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
            ReportPrintTool rptPrintTool = new ReportPrintTool(report);
            PrintingSystemBase prtSysBase = rptPrintTool.PrintingSystem;

            prtSysBase.SetCommandVisibility(new PrintingSystemCommand[]{
                        //PrintingSystemCommand.Background,
                        //PrintingSystemCommand.ClosePreview,
                        //PrintingSystemCommand.Customize,
                        //PrintingSystemCommand.DocumentMap,
                        //PrintingSystemCommand.EditPageHF,
                        //PrintingSystemCommand.ExportCsv,
                        //PrintingSystemCommand.ExportFile,
                        //PrintingSystemCommand.ExportGraphic,
                        //PrintingSystemCommand.ExportHtm,
                        //PrintingSystemCommand.ExportMht,
                        //PrintingSystemCommand.ExportPdf,
                        //PrintingSystemCommand.ExportRtf,
                        //PrintingSystemCommand.ExportTxt,
                        //PrintingSystemCommand.ExportXls,
                        //PrintingSystemCommand.ExportXlsx,
                        //PrintingSystemCommand.ExportXps,
                        //PrintingSystemCommand.File,
                        //PrintingSystemCommand.FillBackground ,
                        //PrintingSystemCommand.Find,
                        //PrintingSystemCommand.HandTool,
                        //PrintingSystemCommand.Magnifier,
                        //PrintingSystemCommand.MultiplePages,
                        //PrintingSystemCommand.Open,
                        //PrintingSystemCommand.PageLayout,
                        //PrintingSystemCommand.PageLayoutContinuous,
                        //PrintingSystemCommand.PageMargins,
                        //PrintingSystemCommand.PageOrientation,
                        //PrintingSystemCommand.PageSetup,
                        //PrintingSystemCommand.PaperSize,
                        PrintingSystemCommand.Parameters,
                        //PrintingSystemCommand.Pointer,
                        //PrintingSystemCommand.Print,
                        //PrintingSystemCommand.PrintDirect ,
                        //PrintingSystemCommand.Save,
                        //PrintingSystemCommand.SendCsv,
                        //PrintingSystemCommand.SendFile,
                        //PrintingSystemCommand.SendGraphic,
                        //PrintingSystemCommand.SendMht,
                        //PrintingSystemCommand.SendPdf,
                        //PrintingSystemCommand.SendRtf,
                        //PrintingSystemCommand.SendTxt,
                        //PrintingSystemCommand.SendXls,
                        //PrintingSystemCommand.SendXlsx,
                        //PrintingSystemCommand.SendXps,
                        PrintingSystemCommand.SubmitParameters,
                        //PrintingSystemCommand.View,
                        //PrintingSystemCommand.Watermark                
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

        /// <summary>
        /// 得到包含系统信息的参数列表
        /// </summary>
        /// <returns></returns>
        public static List<Parameter> GetSystemInfo_ParamList()
        {
            List<Parameter> paramList = new List<Parameter>();
            Parameter p1 = new Parameter();
            p1.Name = "公司名称";
            p1.Value = SystemInfo.CompanyName;            
            paramList.Add(p1);
            Parameter p2 = new Parameter();
            p2.Name = "公司地址";
            p2.Value = SystemInfo.CompAddress;            
            paramList.Add(p2);
            Parameter p3 = new Parameter();
            p3.Name = "公司邮编";
            p3.Value = SystemInfo.CompZipCode;            
            paramList.Add(p3);
            Parameter p4 = new Parameter();
            p4.Name = "公司电话";
            p4.Value = SystemInfo.CompTel;            
            paramList.Add(p4);
            Parameter p5 = new Parameter();
            p5.Name = "公司传真";
            p5.Value = SystemInfo.CompFax;            
            paramList.Add(p5);
            Parameter p6 = new Parameter();
            p6.Name = "公司网址";
            p6.Value = SystemInfo.CompWebSite;           
            paramList.Add(p6);
            Parameter p7 = new Parameter();
            p7.Name = "公司商标";
            p7.Value = SystemInfo.CompImage;
            paramList.Add(p7);

            return paramList;
        }

    }
}
