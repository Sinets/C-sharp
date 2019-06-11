using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using WSN_New_DLL;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace IntelligentWarehouseManagementSystem
{
    public partial class TemperatureAndHumidityMonitoringForm : Form
    {
        private delegate void ShowLabelDel(Label label, string message, bool visible);
        private delegate void ShowPictureBoxDel(PictureBox pictureBox, bool visible);
        private delegate void ShowChartDel(Chart chart, string series, double yValue);

        private Gateway GateWay;

        string[] strData = { "0000", "FFFFFFFFFF" };

        private Thread thread;

        private string strTemp = "0";
        private string strHumi = "0";

        private string strMaxTemp = "30";
        private string strMinTemp = "20";
        private string strMaxHumi = "80";
        private string strMinHumi = "20";
        private bool IsRead = false;
        
        public TemperatureAndHumidityMonitoringForm()
        {
            InitializeComponent();
        }

        private void TemperatureAndHumidityMonitoringForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            IsRead = false;
            Thread.Sleep(500);
            if (this.thread != null && thread.ThreadState == ThreadState.Background)
            {
                thread.Abort();
                thread = null;
            }

            if (this.GateWay != null)
            {
                GateWay.Disconnect();
            }
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            MainForm.mainform.Show();
            this.Hide();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtGatewayIP.Text == "" || txtGatewayPort.Text == "")
            {
                MessageBox.Show("请填写IP地址和端口号！");
                return;
            }
            GateWay = new WSN_New_DLL.Gateway(txtGatewayIP.Text, Convert.ToInt32(txtGatewayPort.Text));
            GateWay.EventDataArrival += GateWay_EventDataArrival;
            if (GateWay.Connect())
            {
                lblT2.Visible = true;
                lblT2.Text = "通道建立成功！";
                btnConnect.Enabled = false;
            }
            else
            {
                lblT2.Visible = true;
                lblT2.Text = "通道建立失败！";
            }
        }
        void GateWay_EventDataArrival(List<string[]> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i][0].Substring(0, 1) == "3")
                {
                    strData[0] = data[i][0];
                    strData[1] = data[i][1];
                    break;
                }
            }
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            if (GateWay.SendData(strData))
            {
                lblPingInfo.Visible = true;
                lblPingInfo.Text = "Ping成功！";
            }
            else
            {
                lblPingInfo.Visible = true;
                lblPingInfo.Text = "Ping失败！";
            }
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            strMaxTemp = txtMaxTemp.Text.Trim();
            strMinTemp = txtMinTemp.Text.Trim();
            strMaxHumi = txtMaxHumi.Text.Trim();
            strMinHumi = txtMinHumi.Text.Trim();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (btnCheck.Text == "开始检测")
            {
                IsRead = true;
                thread = new Thread(new ThreadStart(Check));
                thread.IsBackground = true;
                thread.Start();
                btnCheck.Text = "停止检测";
            }
            else
            {
                IsRead = false;
                if (thread != null)
                {
                    thread.Abort();
                    thread = null;
                }

                btnCheck.Text = "开始检测";
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }
        }
        private void ShowLabel(Label lbl, string msg, bool visible)
        {
            if (lbl.InvokeRequired)
            {
                ShowLabelDel sld = new ShowLabelDel(ShowLabel);
                this.Invoke(sld, lbl, msg, visible);
            }
            else
            {
                lbl.Visible = visible;
                lbl.Text = msg;
            }
        }
        private void Check()
        {
            while (IsRead)
            {
                GateWay.SendData(new string[] { strData[0], "FFFFFFFFFF" });
                Thread.Sleep(1000);
                strTemp = Convert.ToInt32(strData[1].Substring(2, 2), 16).ToString();
                strHumi = Convert.ToInt32(strData[1].Substring(6, 2), 16).ToString();
                if (strTemp == "255" || strHumi == "255")
                {
                    continue;
                }
                Invoke(new Action(() =>
                {
                    this.chart1.Series[0].Points.AddXY(DateTime.Now, strTemp);
                    this.chart1.Series[1].Points.AddXY(DateTime.Now, strHumi);
                }));


                if (Convert.ToDouble(strTemp) > Convert.ToDouble(strMaxTemp))
                {
                    ShowLabel(lblTemp, "温度太高", true);
                    //ShowPictureBox(picTempAndHumi, true);
                }
                else if (Convert.ToDouble(strTemp) < Convert.ToDouble(strMinTemp))
                {
                    ShowLabel(lblTemp, "温度太低", true);
                    //ShowPictureBox(picTempAndHumi, true);
                }
                else
                {
                    ShowLabel(lblTemp, "", false);
                    if (Convert.ToDouble(strHumi) <= Convert.ToDouble(strMaxHumi) && Convert.ToDouble(strHumi) >= Convert.ToDouble(strMinHumi))
                    {
                        //ShowPictureBox(picTempAndHumi, false);
                    }
                }

                if (Convert.ToDouble(strHumi) > Convert.ToDouble(strMaxHumi))
                {
                    ShowLabel(lblHumi, "湿度太高", true);
                    //ShowPictureBox(picTempAndHumi, true);
                }
                else if (Convert.ToDouble(strHumi) < Convert.ToDouble(strMinHumi))
                {
                    ShowLabel(lblHumi, "湿度太低", true);
                    //ShowPictureBox(picTempAndHumi, true);
                }
                else
                {
                    ShowLabel(lblHumi, "", false);
                    if (Convert.ToDouble(strTemp) <= Convert.ToDouble(strMaxTemp) && Convert.ToDouble(strTemp) >= Convert.ToDouble(strMinTemp))
                    {
                        //ShowPictureBox(picTempAndHumi, false);
                    }
                }
            }
        }

        private void TemperatureAndHumidityMonitoringForm_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void txtMaxTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)8))
            {
                if ((e.KeyChar == (char)8))
                {
                    e.Handled = false;
                    return;
                }
                else
                {
                    int len = ((TextBox)sender).Text.Length;
                    if (len == 0 && e.KeyChar != '0')
                    {
                        e.Handled = false;
                        return;
                    }
                    else if (len == 0)
                    {
                        return;
                    }
                    e.Handled = false;
                }
            }
        }

        private void txtGatewayIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)8) || (e.KeyChar == '.'))
            {
                if ((e.KeyChar == (char)8))
                {
                    e.Handled = false;
                    return;
                }
                else
                {
                    int len = ((TextBox)sender).Text.Length;
                    if (len == 0 && e.KeyChar != '0' && e.KeyChar != '.')
                    {
                        e.Handled = false;
                        return;
                    }
                    else if (len == 0)
                    {
                        return;
                    }
                    e.Handled = false;
                }
            }
        }

        private void txtGatewayIP_Validating(object sender, CancelEventArgs e)
        {
            string[] ip = ((TextBox)sender).Text.Split('.');
            if (ip.Length != 4)
            {
                ((TextBox)sender).Text = "";
                MessageBox.Show("IP地址格式不正确！");
                return;
            }
            else
            {
                foreach (string item in ip)
                {
                    if (item == "")
                    {
                        ((TextBox)sender).Text = "";
                        MessageBox.Show("IP地址格式不正确！");
                        return;
                    }
                }
            }

            IPAddress match = IPAddress.Parse(((TextBox)sender).Text);

            if (match.AddressFamily != AddressFamily.InterNetwork)
            {
                ((TextBox)sender).Text = "";
                MessageBox.Show("IP地址格式不正确！");
            }
        }
        

    }
}
