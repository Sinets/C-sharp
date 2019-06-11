using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WSN_New_DLL
{
    public class TimeOutSocket
    {
        private static bool IsConnectionSuccessful = false;
        private static Exception socketexception;
        private static ManualResetEvent TimeoutObject = new ManualResetEvent(false);

        /// <summary>
        /// 检测连接是否异常
        /// </summary>
        /// <param name="remoteEndPoint"></param>
        /// <param name="timeoutMiliSecond"></param>
        /// <returns></returns>
        public static bool TryConnect(IPEndPoint remoteEndPoint, int timeoutMiliSecond)
        {
            TimeoutObject.Reset();
            socketexception = null;

            string serverip = Convert.ToString(remoteEndPoint.Address);
            int serverport = remoteEndPoint.Port;
            TcpClient tcpclient = new TcpClient();

            tcpclient.BeginConnect(serverip, serverport, new AsyncCallback(CallBackMethod), tcpclient);

            if (TimeoutObject.WaitOne(timeoutMiliSecond, false))
            {
                if (IsConnectionSuccessful)
                {
                    tcpclient.Close();
                    return true;
                }
                else
                {
                    tcpclient.Close();
                    return false;
                }
            }
            else
            {
                tcpclient.Close();
                return false;
            }
        }

        private static void CallBackMethod(IAsyncResult asyncresult)
        {
            try
            {
                IsConnectionSuccessful = false;
                TcpClient tcpclient = asyncresult.AsyncState as TcpClient;

                if (tcpclient.Client != null)
                {
                    tcpclient.EndConnect(asyncresult);
                    IsConnectionSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                IsConnectionSuccessful = false;
                socketexception = ex;
            }
            finally
            {
                TimeoutObject.Set();
            }
        }
    }
}
