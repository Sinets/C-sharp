namespace IntelligentWarehouseManagementSystem
{
    partial class MerchandiseOutOfTheLibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MerchandiseOutOfTheLibraryForm));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvGoodsInOut = new System.Windows.Forms.ListView();
            this.colCardNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpirationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCardID = new System.Windows.Forms.ComboBox();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "出库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvGoodsInOut);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 278);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出库详单";
            // 
            // lsvGoodsInOut
            // 
            this.lsvGoodsInOut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCardNum,
            this.colCargo,
            this.colName,
            this.colPrice,
            this.colExpirationDate,
            this.columnHeader1});
            this.lsvGoodsInOut.Location = new System.Drawing.Point(6, 25);
            this.lsvGoodsInOut.Name = "lsvGoodsInOut";
            this.lsvGoodsInOut.Size = new System.Drawing.Size(463, 251);
            this.lsvGoodsInOut.TabIndex = 4;
            this.lsvGoodsInOut.UseCompatibleStateImageBehavior = false;
            this.lsvGoodsInOut.View = System.Windows.Forms.View.Details;
            // 
            // colCardNum
            // 
            this.colCardNum.Text = "卡号";
            this.colCardNum.Width = 120;
            // 
            // colCargo
            // 
            this.colCargo.Text = "库存仓位";
            this.colCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCargo.Width = 65;
            // 
            // colName
            // 
            this.colName.Text = "商品名称";
            this.colName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colName.Width = 85;
            // 
            // colPrice
            // 
            this.colPrice.Text = "价格";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.Text = "保质期";
            this.colExpirationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colExpirationDate.Width = 75;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "状态";
            this.columnHeader1.Width = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(361, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文仿宋", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(335, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "黑米科技";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCardID);
            this.groupBox1.Controls.Add(this.txtSeat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 115);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品信息";
            // 
            // cmbCardID
            // 
            this.cmbCardID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCardID.FormattingEnabled = true;
            this.cmbCardID.Location = new System.Drawing.Point(91, 27);
            this.cmbCardID.Name = "cmbCardID";
            this.cmbCardID.Size = new System.Drawing.Size(100, 20);
            this.cmbCardID.TabIndex = 3;
            // 
            // txtSeat
            // 
            this.txtSeat.Enabled = false;
            this.txtSeat.Location = new System.Drawing.Point(91, 67);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(100, 21);
            this.txtSeat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "所在货仓：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标 签 号：";
            // 
            // MerchandiseOutOfTheLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 502);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MerchandiseOutOfTheLibraryForm";
            this.Text = "商品出库";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MerchandiseOutOfTheLibraryForm_FormClosed);
            this.Load += new System.EventHandler(this.MerchandiseOutOfTheLibraryForm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvGoodsInOut;
        private System.Windows.Forms.ColumnHeader colCardNum;
        private System.Windows.Forms.ColumnHeader colCargo;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colExpirationDate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox cmbCardID;

    }
}