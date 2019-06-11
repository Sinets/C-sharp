using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using MySql.Data.MySqlClient;
using System.Xml;

namespace IntelligentWarehouseManagementSystem.MyClass
{
    /// <summary>
    /// 方法类
    /// </summary>
    class ClassAll
    {
        //public static SqlServer_dll.DbConnection dbc;
        //public static SqlServer_dll.DbOperate dbo;
        public static string sqlcon = "server=localhost;user id=root;password=sfz.173689;database=storage"; //根据自己的设置
        //创建数据库连接对象
        public static MySqlConnection mycon = new MySqlConnection(sqlcon);


        public static KV_ISO15693.Reader Reader = new KV_ISO15693.Reader();
        public static SerialPort serialPort = new SerialPort();

        #region 返回数据库连接字符串

        /// <summary>
        /// 返回数据库连接字符串
        /// </summary>
        /// <param name="filePath">配置文件的路径</param>
        /// <returns></returns>
        public static string GetDatabaseConnect(string filePath)
        {
            string connStr = "";

            if (File.Exists(filePath))
            {
                try
                {
                    connStr = File.ReadAllText(filePath).Trim();
                }
                catch (Exception err)
                {
                    throw err;
                }
            }
            else
            {
                throw new Exception("不存在配置文件！");
            }

            return connStr;
        }

        #endregion


        #region 通道号设置方法

        /// <summary>
        /// 通道号设置方法
        /// </summary>
        /// <param name="str"></param>
        public static void Antenna(string str, bool isShow)
        {
            Byte AntannaIndex = 0;
            MyClass.ClassAll.Reader.SetAntanna(AntannaIndex);

            if (str != "")
            {
                if (str == "1")
                {
                    AntannaIndex = 0x01;
                }
                if (str == "2")
                {
                    AntannaIndex = 0x02;
                }
                if (str == "3")
                {
                    AntannaIndex = 0x03;
                }
                if (str == "4")
                {
                    AntannaIndex = 0x04;
                }
                if (str == "5")
                {
                    AntannaIndex = 0x05;
                }
                if (str == "6")
                {
                    AntannaIndex = 0x06;
                }
                if (str == "7")
                {
                    AntannaIndex = 0x07;
                }
                if (str == "8")
                {
                    AntannaIndex = 0x08;
                }
            }
            else
            {
                if (isShow) MessageBox.Show("请选择通道号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (MyClass.ClassAll.Reader.SetAntanna(AntannaIndex) == 0x00)
            {
                if (isShow) MessageBox.Show("通道设置成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region 返回XML文件的信息
        /// <summary>
        /// 返回XML文件的信息
        /// </summary>
        /// <param name="filePath">配置文件中的路径</param>
        /// <returns></returns>
        public static string[] GetOpenClosePorts(string filePath)
        {
            string Num, LED;
            string[] Ports = new string[2];
            if (File.Exists(filePath))
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(filePath);
                    XmlNode nodeRoot = xmlDoc.SelectSingleNode("Root");
                    XmlNode nodeDB = nodeRoot.SelectSingleNode("DB");
                    Num = nodeDB.SelectSingleNode("ISO15693").InnerText;
                    LED = nodeDB.SelectSingleNode("LED").InnerText;

                    //将两个变量的值分别放入数组中
                    Ports[0] = Num;
                    Ports[1] = LED;

                }
                catch (Exception err)
                {
                    throw err;
                }
            }
            else
            {
                throw new Exception("不存在配置文件");
            }

            return Ports;

        }

        #endregion

        #region 打开串口

        /// <summary>
        /// 打开LED屏串口和15693串口
        /// </summary>
        public static void OpenPort()
        {
            string[] Ports = new string[2];
            Ports = GetOpenClosePorts(AppDomain.CurrentDomain.BaseDirectory + "Ports.xml");
            
            //打开15693读写器

            if (Reader.IsOpen)
            {
                MessageBox.Show("15693读写器串口已打开");
            }

            if (Reader.OpenSerialPort(Ports[0], 115200) == 0)
            {
                MessageBox.Show("15693读写器串口打开成功");
            }
            else
            {
                MessageBox.Show("打开失败");
            }

            //if (!serialPort.IsOpen)
            //{
            //    try
            //    {
            //        serialPort.PortName = Ports[1];
            //        serialPort.Open();

            //        MessageBox.Show("LED屏串口打开成功");

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("错误" + ex.Message);

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("LED屏串口已打开");
            //}

        }

        #endregion

        #region 关闭串口

        public static void ClosePort()
        {
            if (!Reader.IsOpen)
            {
                MessageBox.Show("串口已处于关闭状态");
            }
            else
            {
                Reader.CloseSerialPort();
                MessageBox.Show("15693读写器串口关闭成功");
            }
            //if (serialPort.IsOpen)
            //{
            //    serialPort.Close();
            //}
            //else
            //{
            //    MessageBox.Show("串口处于关闭状态");
            //    MessageBox.Show("LED屏关闭成功");
            //}
        }

        #endregion

    }
}
