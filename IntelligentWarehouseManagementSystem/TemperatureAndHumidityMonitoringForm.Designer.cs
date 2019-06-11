namespace IntelligentWarehouseManagementSystem
{
    partial class TemperatureAndHumidityMonitoringForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemperatureAndHumidityMonitoringForm));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.txtMinHumi = new System.Windows.Forms.TextBox();
            this.txtMaxHumi = new System.Windows.Forms.TextBox();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHumi = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCheck = new System.Windows.Forms.Button();
            this.gpboxPing = new System.Windows.Forms.GroupBox();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblPingInfo = new System.Windows.Forms.Label();
            this.btnPing = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtGatewayPort = new System.Windows.Forms.TextBox();
            this.txtGatewayIP = new System.Windows.Forms.TextBox();
            this.lblGatewayPort = new System.Windows.Forms.Label();
            this.lblGatewayIP = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gpboxPing.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSaveSetting);
            this.groupBox4.Controls.Add(this.txtMinHumi);
            this.groupBox4.Controls.Add(this.txtMaxHumi);
            this.groupBox4.Controls.Add(this.txtMinTemp);
            this.groupBox4.Controls.Add(this.txtMaxTemp);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(421, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 212);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "报警阀值设置";
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.Location = new System.Drawing.Point(81, 175);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSetting.TabIndex = 2;
            this.btnSaveSetting.Text = "保存设置";
            this.btnSaveSetting.UseVisualStyleBackColor = true;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // txtMinHumi
            // 
            this.txtMinHumi.Location = new System.Drawing.Point(94, 140);
            this.txtMinHumi.Name = "txtMinHumi";
            this.txtMinHumi.Size = new System.Drawing.Size(75, 21);
            this.txtMinHumi.TabIndex = 1;
            this.txtMinHumi.Text = "20";
            // 
            // txtMaxHumi
            // 
            this.txtMaxHumi.Location = new System.Drawing.Point(94, 101);
            this.txtMaxHumi.Name = "txtMaxHumi";
            this.txtMaxHumi.Size = new System.Drawing.Size(75, 21);
            this.txtMaxHumi.TabIndex = 1;
            this.txtMaxHumi.Text = "80";
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(94, 62);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(75, 21);
            this.txtMinTemp.TabIndex = 1;
            this.txtMinTemp.Text = "20";
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(94, 23);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(75, 21);
            this.txtMaxTemp.TabIndex = 1;
            this.txtMaxTemp.Text = "30";
            this.txtMaxTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxTemp_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "最低湿度：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "最高湿度：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "最低温度：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(175, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(175, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(175, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "℃";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(175, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "℃";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "最高温度：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHumi);
            this.groupBox2.Controls.Add(this.lblTemp);
            this.groupBox2.Location = new System.Drawing.Point(419, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 196);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "警报状态：";
            // 
            // lblHumi
            // 
            this.lblHumi.AutoSize = true;
            this.lblHumi.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHumi.ForeColor = System.Drawing.Color.Red;
            this.lblHumi.Location = new System.Drawing.Point(64, 100);
            this.lblHumi.Name = "lblHumi";
            this.lblHumi.Size = new System.Drawing.Size(94, 21);
            this.lblHumi.TabIndex = 2;
            this.lblHumi.Text = "湿度警报";
            this.lblHumi.Visible = false;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTemp.ForeColor = System.Drawing.Color.Red;
            this.lblTemp.Location = new System.Drawing.Point(64, 72);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(94, 21);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "温度警报";
            this.lblTemp.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Location = new System.Drawing.Point(10, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 212);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "温湿度检测";
            // 
            // chart1
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 20);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "温度℃";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "湿度%";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(288, 186);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(297, 116);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "开始检测";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // gpboxPing
            // 
            this.gpboxPing.Controls.Add(this.lblT2);
            this.gpboxPing.Controls.Add(this.lblPingInfo);
            this.gpboxPing.Controls.Add(this.btnPing);
            this.gpboxPing.Controls.Add(this.btnConnect);
            this.gpboxPing.Controls.Add(this.txtGatewayPort);
            this.gpboxPing.Controls.Add(this.txtGatewayIP);
            this.gpboxPing.Controls.Add(this.lblGatewayPort);
            this.gpboxPing.Controls.Add(this.lblGatewayIP);
            this.gpboxPing.Location = new System.Drawing.Point(10, 13);
            this.gpboxPing.Name = "gpboxPing";
            this.gpboxPing.Size = new System.Drawing.Size(405, 196);
            this.gpboxPing.TabIndex = 7;
            this.gpboxPing.TabStop = false;
            this.gpboxPing.Text = "Ping指令";
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblT2.Location = new System.Drawing.Point(130, 160);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(17, 12);
            this.lblT2.TabIndex = 36;
            this.lblT2.Text = "T2";
            this.lblT2.Visible = false;
            // 
            // lblPingInfo
            // 
            this.lblPingInfo.AutoSize = true;
            this.lblPingInfo.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblPingInfo.Location = new System.Drawing.Point(270, 160);
            this.lblPingInfo.Name = "lblPingInfo";
            this.lblPingInfo.Size = new System.Drawing.Size(53, 12);
            this.lblPingInfo.TabIndex = 34;
            this.lblPingInfo.Text = "PingInfo";
            this.lblPingInfo.Visible = false;
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(263, 126);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(69, 25);
            this.btnPing.TabIndex = 13;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(96, 126);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(87, 24);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "建立通道";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtGatewayPort
            // 
            this.txtGatewayPort.Location = new System.Drawing.Point(272, 56);
            this.txtGatewayPort.Name = "txtGatewayPort";
            this.txtGatewayPort.Size = new System.Drawing.Size(100, 21);
            this.txtGatewayPort.TabIndex = 9;
            this.txtGatewayPort.Text = "4000";
            // 
            // txtGatewayIP
            // 
            this.txtGatewayIP.Location = new System.Drawing.Point(96, 56);
            this.txtGatewayIP.Name = "txtGatewayIP";
            this.txtGatewayIP.Size = new System.Drawing.Size(100, 21);
            this.txtGatewayIP.TabIndex = 6;
            this.txtGatewayIP.Text = "192.168.1.230";
            this.txtGatewayIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGatewayIP_KeyPress);
            this.txtGatewayIP.Validating += new System.ComponentModel.CancelEventHandler(this.txtGatewayIP_Validating);
            // 
            // lblGatewayPort
            // 
            this.lblGatewayPort.AutoSize = true;
            this.lblGatewayPort.Location = new System.Drawing.Point(202, 59);
            this.lblGatewayPort.Name = "lblGatewayPort";
            this.lblGatewayPort.Size = new System.Drawing.Size(65, 12);
            this.lblGatewayPort.TabIndex = 1;
            this.lblGatewayPort.Text = "网关端口：";
            // 
            // lblGatewayIP
            // 
            this.lblGatewayIP.AutoSize = true;
            this.lblGatewayIP.Location = new System.Drawing.Point(37, 59);
            this.lblGatewayIP.Name = "lblGatewayIP";
            this.lblGatewayIP.Size = new System.Drawing.Size(53, 12);
            this.lblGatewayIP.TabIndex = 0;
            this.lblGatewayIP.Text = "网关IP：";
            // 
            // TemperatureAndHumidityMonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 441);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpboxPing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TemperatureAndHumidityMonitoringForm";
            this.Text = "温湿度监控";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TemperatureAndHumidityMonitoringForm_FormClosed);
            this.Load += new System.EventHandler(this.TemperatureAndHumidityMonitoringForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gpboxPing.ResumeLayout(false);
            this.gpboxPing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSaveSetting;
        private System.Windows.Forms.TextBox txtMinHumi;
        private System.Windows.Forms.TextBox txtMaxHumi;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHumi;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox gpboxPing;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblPingInfo;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtGatewayPort;
        private System.Windows.Forms.TextBox txtGatewayIP;
        private System.Windows.Forms.Label lblGatewayPort;
        private System.Windows.Forms.Label lblGatewayIP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}