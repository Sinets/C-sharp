using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WSN_New_DLL
{
    public class Gateway
    {
        #region Delegate&Event

        public delegate void DelegateDataArrival(List<string[]> data);
        public event DelegateDataArrival EventDataArrival;

        #endregion

        #region Variable

        /// <summary>
        /// 通信通道
        /// </summary>
        private Socket socket;

        /// <summary>
        /// 接收缓存
        /// </summary>
        private string dataReceiveStr = "";

        /// <summary>
        /// 接收到字节数
        /// </summary>
        private int countReceive = 0;

        /// <summary>
        /// 发送的字节数
        /// </summary>
        private int countSend = 0;

        /// <summary>
        /// 转换数据缓存
        /// </summary>
        private List<string[]> dataArrival = new List<string[]>();

        private Thread tSocketReceive;
        private Thread tParseReceive;

        private string remoteHost = "127.0.0.1";
        private int remotePort = 9999;
        
        #endregion

        #region Property

        public string RemoteHost
        {
            get 
            {
                return this.remoteHost;
            }
            set
            {
                this.remoteHost = value;
            }
        }

        public int RemotePort
        {
            get
            {
                return this.remotePort;
            }
            set
            {
                this.remotePort = value;
            }
        }
        
        #endregion

        #region Constructor

        public Gateway(string strIP, int iPort)
        {
            this.remoteHost = strIP;
            this.remotePort = iPort;
        }
        
        #endregion

        #region PublicMethod

        public bool Connect()
        {
            try
            {
                IPAddress ip = IPAddress.Parse(remoteHost);
                IPEndPoint ipe = new IPEndPoint(ip, remotePort);                

                //链接监听端
                this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                LingerOption lingerOption = new LingerOption(false, 0);
                socket.LingerState = lingerOption;

                this.socket.Connect(ipe);

                //开启接收数据线程
                tSocketReceive = new Thread(new ThreadStart(SocketThread));
                tSocketReceive.IsBackground = true;
                tSocketReceive.Start();

                tParseReceive = new Thread(new ThreadStart(ParseReceive));
                tParseReceive.IsBackground = true;
                tParseReceive.Start();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Disconnect()
        {
            try
            {
                if (this.tSocketReceive != null)
                {
                    this.tSocketReceive.Abort();
                    this.tSocketReceive.DisableComObjectEagerCleanup();
                }

                if (this.tParseReceive != null)
                {
                    this.tParseReceive.Abort();
                    this.tParseReceive.DisableComObjectEagerCleanup();
                }

                if (socket != null)
                {   
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SendData(string[] strData)
        {
            try
            {
                string message = "A5" + strData[0] + strData[1] + "5A";

                byte[] buffer = Converts.StringToBytes(message);

                this.socket.Send(buffer);

                this.countSend = this.countSend + buffer.Length;

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region PrivateMethod

        /// <summary>
        /// 解析接收数据
        /// </summary>
        private void ParseReceive()
        {
            while (true)
            {
                Thread.Sleep(100);

                if (this.dataReceiveStr != "")
                {
                    string tmpReceiveStr = dataReceiveStr;

                    if (tmpReceiveStr.IndexOf("B5") == 0 && tmpReceiveStr.Length % 9 == 0)
                    {
                        this.dataReceiveStr = "";

                        byte[] bufferSend = Converts.StringToBytes(tmpReceiveStr);

                        ByteConvertString(bufferSend);

                        if (EventDataArrival != null && dataArrival.Count > 0)
                        {
                            this.EventDataArrival(dataArrival);
                        }

                        this.dataArrival.Clear();
                    }
                    else
                    {
                        this.dataReceiveStr = "";
                    }
                }
            }
        }


        /// <summary>
        /// 接收数据
        /// </summary>
        private void SocketThread()
        {
            while (true)
            {
                Thread.Sleep(1);

                try
                {
                    byte[] buffer = new byte[1024];
                    int count = this.socket.Receive(buffer);

                    this.countReceive = this.countReceive + count;

                    if (buffer[0] == 0xB5 && count % 9 == 0)
                    {
                        byte[] data = new byte[count];
                        Array.Copy(buffer, 0, data, 0, data.Length);
                        this.dataReceiveStr = this.dataReceiveStr + Converts.BytesToString(data);
                    }
                    else
                    {
                        this.dataReceiveStr = "";
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        private void ByteConvertString(byte[] data)
        {
            for (int i = 0; i < data.Length / 9; i++)
            {
                byte[] tmp = new byte[7];
                Array.Copy(data, i * 9 + 1, tmp, 0, tmp.Length);

                string[] tmp1 = new string[2] { "", "" };
                tmp1[0] = tmp[0].ToString("X2") + tmp[1].ToString("X2");
                for (int j = 2; j < tmp.Length; j++)
                {
                    tmp1[1] += tmp[j].ToString("X2");
                }

                dataArrival.Add(tmp1);
            }
        }

        #endregion
    }
}
