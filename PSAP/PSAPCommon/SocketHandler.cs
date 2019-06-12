using DevExpress.XtraBars.Alerter;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PSAP.PSAPCommon
{
    class SocketHandler
    {
        /// <summary>
        /// 客户端的Socket
        /// </summary>
        public static Socket clientSocket;

        /// <summary>
        /// 临时接收数据字符串
        /// </summary>
        public static string tmpReceiveDataStr = "";

        /// <summary>
        /// 退出程序的状态
        /// </summary>
        public static bool exitApplicationState = false;

        /// <summary>
        /// 主线程内容
        /// </summary>
        private SynchronizationContext mainThreadSynContext;

        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();
        public SocketHandler()
        {
            PSAP.BLL.BSBLL.BSBLL.language(f);
        }

        /// <summary>
        /// 连接服务端
        /// </summary>
        public bool ConnectServer(ref string outMessage)
        {
            mainThreadSynContext = SynchronizationContext.Current;

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, SystemInfo.ServerProtocolType);
            clientSocket = socket;
            try
            {
                socket.Connect(SystemInfo.ServerIP, SystemInfo.ServerPort);
            }
            catch (Exception)
            {
                //outMessage = "连接服务端失败，请检查服务端程序是否启动。";
                outMessage = f.tsmiLjfwds.Text;
                return false;
            }

            Thread thread = new Thread(new ParameterizedThreadStart(ReceiveData));
            thread.IsBackground = true;
            thread.Start(clientSocket);

            string maxCntStr = SendServerAndReturnResult("ClientMaxCnt");
            string[] msgStringArray = maxCntStr.Split('|');

            if (msgStringArray[1] == "1")
            {
                //outMessage = "登陆服务程序的客户端已满，无法登陆，请稍后再进行登陆。";
                outMessage = f.tsmiDlfwcx.Text;
                return false;
            }
            else
            {
                SendServerMessage(string.Format("SystemInfo|{0}|{1}", new SystemHandler().GetHostName(), SystemInfo.user.LoginID));
                return true;
            }
        }

        /// <summary>
        /// 断开服务端连接
        /// </summary>
        public void DisconnectServer(Socket proxSocket)
        {
            try
            {
                StopConnetct(proxSocket);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 接收数据
        /// </summary>
        private void ReceiveData(object obj)
        {
            Socket proxSocket = obj as Socket;
            byte[] data = new byte[1024 * 1024];
            while (true)
            {
                int readLen = 0;
                try
                {
                    readLen = proxSocket.Receive(data, 0, data.Length, SocketFlags.None);
                }
                catch (Exception)
                { //异常退出时  
                    StopConnetct(proxSocket);
                    //ShowMessageExitApplication("客户端程序与服务端程序断开连接");
                    ShowMessageExitApplication(f.tsmiKhdcxy.Text);

                    return;
                }
                if (readLen <= 0)
                { //客户端正常退出  
                    StopConnetct(proxSocket);
                    //ShowMessageExitApplication("客户端程序与服务端程序断开连接");
                    ShowMessageExitApplication(f.tsmiKhdcxy.Text);

                    return;
                }
                string msgStr = Encoding.Default.GetString(data, 0, readLen);
                if (!HandleReceiveData(proxSocket, msgStr))
                    return;
            }
        }

        /// <summary>
        /// 停止客户端连接
        /// </summary>
        private void StopConnetct(Socket proxSocket)
        {
            try
            {
                if (proxSocket != null && proxSocket.Connected)
                {
                    proxSocket.Shutdown(SocketShutdown.Both);
                    proxSocket.Close(100);
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 处理客户端的数据
        /// </summary>
        private bool HandleReceiveData(Socket proxSocket, string messageStr)
        {
            string[] msgStringArray = messageStr.Split('|');
            if (msgStringArray.Length > 0)
            {
                switch (msgStringArray[0])
                {
                    case "ClientMaxCnt":
                        tmpReceiveDataStr = messageStr;
                        if (msgStringArray[1] == "1")
                        {
                            StopConnetct(proxSocket);
                            return false;
                        }
                        break;
                    case "Close":
                        StopConnetct(proxSocket);
                        //ShowMessageExitApplication("服务端程序退出或者强制关闭当前客户端程序");
                        ShowMessageExitApplication(f.tsmiFwdcxt.Text);

                        break;
                    default:
                        tmpReceiveDataStr = messageStr;
                        break;
                }
            }
            return true;
        }

        /// <summary>
        /// 发送服务端消息
        /// </summary>
        public void SendServerMessage(string messageStr)
        {
            if (clientSocket == null)
            {
                //throw new Exception("客户端Socket初始化失败，无法通信。");
                throw new Exception(f.tsmiKhdsoc.Text);

            }
            if (clientSocket.Connected)
            {
                byte[] data = Encoding.Default.GetBytes(messageStr);
                clientSocket.Send(data, 0, data.Length, SocketFlags.None);
            }
        }

        /// <summary>
        /// 发送服务端程序数据，并且等待返回的结果
        /// </summary>
        public string SendServerAndReturnResult(string sendStr)
        {
            tmpReceiveDataStr = "";
            clientSocket.Send(Encoding.Default.GetBytes(sendStr));//发送数据
            while (true)//定义一个循环接收返回数据
            {
                if (tmpReceiveDataStr == "")
                    Thread.Sleep(200);
                else
                    return tmpReceiveDataStr;
            }
        }

        /// <summary>
        /// 消息提示退出程序
        /// </summary>
        public void ShowMessageExitApplication(string messageStr)
        {
            if (!exitApplicationState)
            {
                exitApplicationState = true;
                int exitSecondInt = 30;

                for (int i = exitSecondInt; i >= 0; i--)
                {
                    switch (i)
                    {
                        case 30:
                        case 20:
                        case 10:
                        case 5:
                            //string msg = string.Format("{0}，系统将于{1}秒后关闭程序。", messageStr, i);
                            string msg = string.Format("{0}，" + f.tsmiXtjy.Text + "{1}" + f.tsmiMhgbcx.Text, messageStr, i);
                            mainThreadSynContext.Post(new SendOrPostCallback(AlertMessageBox), msg);
                            break;
                    }
                    Thread.Sleep(1000);
                }
                Application.Exit();
            }
        }


        /// <summary>
        /// 主线程执行的方法
        /// </summary>
        private void AlertMessageBox(object msg)//由于是主线程的同步对象Post调用，这个是在主线程中执行的
        {
            //new AlertControl().Show(null, "消息提示", DataTypeConvert.GetString(msg));
            new AlertControl().Show(null, f.tsmiXxts.Text, DataTypeConvert.GetString(msg));

        }
    }
}
